using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using stuManage.IDAL;
using stuManage.DBUtility;
namespace stuManage.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Repair
	/// </summary>
	public partial class Repair:IRepair
	{
		public Repair()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(stuManage.Model.Repair model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.flo_num != null)
			{
				strSql1.Append("flo_num,");
				strSql2.Append("'"+model.flo_num+"',");
			}
			if (model.dor_num != null)
			{
				strSql1.Append("dor_num,");
				strSql2.Append("'"+model.dor_num+"',");
			}
			if (model.art_num != null)
			{
				strSql1.Append("art_num,");
				strSql2.Append("'"+model.art_num+"',");
			}
			if (model.repa_rea != null)
			{
				strSql1.Append("repa_rea,");
				strSql2.Append("'"+model.repa_rea+"',");
			}
			if (model.sub_date != null)
			{
				strSql1.Append("sub_date,");
				strSql2.Append("'"+model.sub_date+"',");
			}
			if (model.sol_date != null)
			{
				strSql1.Append("sol_date,");
				strSql2.Append("'"+model.sol_date+"',");
			}
			if (model.repa_fee != null)
			{
				strSql1.Append("repa_fee,");
				strSql2.Append(""+model.repa_fee+",");
			}
			strSql.Append("insert into Repair(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(stuManage.Model.Repair model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Repair set ");
			if (model.flo_num != null)
			{
				strSql.Append("flo_num='"+model.flo_num+"',");
			}
			if (model.dor_num != null)
			{
				strSql.Append("dor_num='"+model.dor_num+"',");
			}
			if (model.art_num != null)
			{
				strSql.Append("art_num='"+model.art_num+"',");
			}
			if (model.repa_rea != null)
			{
				strSql.Append("repa_rea='"+model.repa_rea+"',");
			}
			if (model.sub_date != null)
			{
				strSql.Append("sub_date='"+model.sub_date+"',");
			}
			if (model.sol_date != null)
			{
				strSql.Append("sol_date='"+model.sol_date+"',");
			}
			if (model.repa_fee != null)
			{
				strSql.Append("repa_fee="+model.repa_fee+",");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where ");
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Repair ");
			strSql.Append(" where " );
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public stuManage.Model.Repair GetModel()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" flo_num,dor_num,art_num,repa_rea,sub_date,sol_date,repa_fee ");
			strSql.Append(" from Repair ");
			strSql.Append(" where " );
			stuManage.Model.Repair model=new stuManage.Model.Repair();
			DataSet ds=DbHelperSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public stuManage.Model.Repair DataRowToModel(DataRow row)
		{
			stuManage.Model.Repair model=new stuManage.Model.Repair();
			if (row != null)
			{
				if(row["flo_num"]!=null)
				{
					model.flo_num=row["flo_num"].ToString();
				}
				if(row["dor_num"]!=null)
				{
					model.dor_num=row["dor_num"].ToString();
				}
				if(row["art_num"]!=null)
				{
					model.art_num=row["art_num"].ToString();
				}
				if(row["repa_rea"]!=null)
				{
					model.repa_rea=row["repa_rea"].ToString();
				}
				if(row["sub_date"]!=null && row["sub_date"].ToString()!="")
				{
					model.sub_date=DateTime.Parse(row["sub_date"].ToString());
				}
				if(row["sol_date"]!=null && row["sol_date"].ToString()!="")
				{
					model.sol_date=DateTime.Parse(row["sol_date"].ToString());
				}
				if(row["repa_fee"]!=null && row["repa_fee"].ToString()!="")
				{
					model.repa_fee=decimal.Parse(row["repa_fee"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select flo_num,dor_num,art_num,repa_rea,sub_date,sol_date,repa_fee ");
			strSql.Append(" FROM Repair ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" flo_num,dor_num,art_num,repa_rea,sub_date,sol_date,repa_fee ");
			strSql.Append(" FROM Repair ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Repair ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.emp_num desc");
			}
			strSql.Append(")AS Row, T.*  from Repair T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

