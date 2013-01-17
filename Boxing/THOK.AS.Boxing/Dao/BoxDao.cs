using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using THOK.Util;

namespace THOK.AS.Boxing.Dao
{
    public class BoxDao:BaseDao
    {
        /// <summary>
        /// 查询整件订单主单
        /// </summary>
        /// <returns></returns>
        public DataTable FindMaster()
        {
            string sql = "SELECT ORDERDATE,BATCHNO,SORTNO, ORDERID,ROUTECODE,ROUTENAME,CUSTOMERCODE,CUSTOMERNAME " +
                    "FROM AS_SC_PALLETMASTER";
            return ExecuteQuery(sql).Tables[0];
        }

        /// <summary>
        /// 根据分拣流水号查询整件订单细单
        /// </summary>
        /// <param name="sortNo"></param>
        /// <returns></returns>
        public DataTable FindDetail(string sortNo)
        {
            string sql = string.Format("SELECT SORTNO, ORDERID,CIGARETTECODE,CIGARETTENAME,QUANTITY/50 AS QUANTITY" +
                                            " FROM AS_SC_ORDER A " +
                                            " WHERE SORTNO={0} ORDER BY A.CHANNELGROUP,SORTNO", sortNo);
            return ExecuteQuery(sql).Tables[0];
        }

        /// <summary>
        /// 查询整件客户订单主单
        /// </summary>
        /// <returns></returns>
        public DataTable FindPackMaster()
        {
            string sql = "SELECT ROW_NUMBER() OVER(ORDER BY MIN(SORTNO)) AS PACKNO,MIN(SORTNO) AS SORTNO ,ORDERDATE,ORDERID,ROUTECODE,ROUTENAME,CUSTOMERCODE,CUSTOMERNAME,SUM(QUANTITY)/50 AS QUANTITY, SUM(QUANTITY1) AS QUANTITY1 ," +
                            "CASE WHEN SUM(PACKQUANTITY)=SUM(QUANTITY) THEN '已发送' ELSE '未发送' END [PACKAGE], " +
                            " CASE WHEN SUM(PACKQUANTITY1)=SUM(QUANTITY1) THEN '已发送' ELSE '未发送' END [PACKAGE1]  " +
                            "FROM AS_SC_PALLETMASTER GROUP BY ORDERDATE,ROUTECODE,ROUTENAME,ORDERID,CUSTOMERCODE,CUSTOMERNAME ORDER BY SORTNO";
            return ExecuteQuery(sql).Tables[0];
        }

        /// <summary>
        /// 查询整件客户订单明细
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public DataTable FindPackDetail(string orderId)
        {
            string sql = string.Format("SELECT SORTNO, ORDERID," +
                                " CIGARETTECODE,CIGARETTENAME,QUANTITY/50 AS QUANTITY" +
                                " FROM AS_SC_ORDER A " +
                                " WHERE ORDERID={0} ORDER BY CHANNELGROUP,SORTNO ASC", orderId);
            return ExecuteQuery(sql).Tables[0];
        }

        /// <summary>
        /// 查询卷烟信息
        /// </summary>
        /// <returns></returns>
        public DataTable FindCigarettes()
        {
            string sql = "SELECT CIGARETTECODE,CIGARETTENAME,SUM(QUANTITY) FROM AS_SC_ORDER GROUP BY CIGARETTECODE,CIGARETTENAME ORDER BY CIGARETTECODE";
            return ExecuteQuery(sql).Tables[0];
        }

        /// <summary>
        /// 根据条件查询整件订单主单
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public DataTable FindPackMaster(string[] filter)
        {
            string sql = "SELECT B.* FROM " +
                            " (" +
                                " SELECT ROW_NUMBER() OVER(ORDER BY MIN(A.SORTNO)) AS PACKNO," +
                                " MIN(A.SORTNO) AS SORTNO ,A.ORDERDATE,A.ORDERID,A.ROUTECODE,A.ROUTENAME," +
                                " A.CUSTOMERCODE,A.CUSTOMERNAME,SUM(A.QUANTITY)/50 AS QUANTITY," +
                                " CASE WHEN SUM(A.PACKQUANTITY)=SUM(A.QUANTITY) THEN '已发送' ELSE '未发送' END PACKAGE" +
                                " FROM AS_SC_PALLETMASTER A" +
                                " GROUP BY A.ORDERDATE,A.ROUTECODE,A.ROUTENAME,A.ORDERID,A.CUSTOMERCODE,A.CUSTOMERNAME " +
                            " ) B " +
                            " LEFT JOIN AS_SC_ORDER C ON B.ORDERID = C.ORDERID " +
                            " WHERE {0} " +
                            " GROUP BY B.PACKNO,B.SORTNO,B.ORDERDATE,B.ROUTECODE,B.ROUTENAME,B.ORDERID,B.CUSTOMERCODE,B.CUSTOMERNAME,B.QUANTITY,B.PACKAGE" +
                            " {1} " +
                            " ORDER BY SORTNO";
            return ExecuteQuery(string.Format(sql, filter)).Tables[0];
        }

        /// <summary>
        /// 查询所有整件订单信息
        /// </summary>
        /// <returns></returns>
        public DataTable FindAllOrder()
        {
            string sql = @"SELECT distinct(A.SORTNO),ROUTENAME, A.CIGARETTENAME,CUSTOMERNAME,B.CUSTOMERCODE,A.ORDERID,B.AREANAME,B.ADDRESS,A.ORDERDATE
                          FROM AS_SC_ORDER A
                          LEFT JOIN AS_SC_PALLETMASTER  B ON A.ORDERID=B.ORDERID";
            return ExecuteQuery(sql).Tables[0];
        }

        /// <summary>
        /// 查询所有整件订单信息并按品牌排序
        /// </summary>
        /// <returns></returns>
        public DataTable FindAllOrderByBrand()
        {
            string sql = @"SELECT ROW_NUMBER() OVER (ORDER BY B.CIGARETTECODE,A.AREASORTID,A.ROUTESORTID,CUSTOMERSORTID) AS SORTNO,A.ROUTENAME,B.CIGARETTENAME,A.CUSTOMERNAME,A.CUSTOMERCODE,A.ORDERID,A.AREANAME,A.ADDRESS,B.ORDERDATE
                            FROM AS_SC_PALLETMASTER A   
                            LEFT JOIN AS_SC_ORDER B ON A.ORDERDATE = B.ORDERDATE AND A.BATCHNO = B.BATCHNO AND A.LINECODE=B.LINECODE AND A.SORTNO=B.SORTNO   
                            GROUP BY A.ORDERDATE,A.LINECODE,A.ROUTECODE,A.ROUTENAME,A.ORDERID,A.CUSTOMERCODE,A.CUSTOMERNAME,A.SORTNO,B.CIGARETTECODE,B.CIGARETTENAME,A.AREANAME,A.ADDRESS,B.ORDERDATE,A.AREACODE,
	                        AREASORTID,ROUTESORTID,CUSTOMERSORTID
                            ORDER BY B.CIGARETTECODE,A.AREASORTID,A.ROUTESORTID,CUSTOMERSORTID,A.SORTNO";
            return ExecuteQuery(sql).Tables[0];
        }

        /// <summary>
        /// 插入整件订单主表
        /// </summary>
        /// <param name="masterTable"></param>
        public void InsertMaster(DataTable masterTable)
        {
            ExecuteQuery("TRUNCATE TABLE AS_SC_PALLETMASTER");
            BatchInsert(masterTable, "AS_SC_PALLETMASTER");
        }

        /// <summary>
        /// 插入整件订单细表
        /// </summary>
        /// <param name="orderTable"></param>
        public void InsertOrder(DataTable orderTable)
        {
            ExecuteQuery("TRUNCATE TABLE AS_SC_ORDER");
            BatchInsert(orderTable, "AS_SC_ORDER");
        }
    }
}
