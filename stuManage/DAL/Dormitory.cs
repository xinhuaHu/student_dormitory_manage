using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using stuManage.IDAL;
using stuManage.DBUtility;
namespace stuManage.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Dormitory
	/// </summary>
	public partial class Dormitory:IDormitory
	{
		public Dormitory()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string flo_num,string dor_num)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Dormitory");
			strSql.Append(" where flo_num='"+flo_num+"' and dor_num='"+dor_num+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(stuManage.Model.Dormitory model)
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
			if (model.num_occupants != null)
			{
				strSql1.Append("num_occupants,");
				strSql2.Append(""+model.num_occupants+",");
			}
			if (model.live_num != null)
			{
				strSql1.Append("live_num,");
				strSql2.Append(""+model.live_num+",");
			}
			strSql.Append("insert into Dormitory(");
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
		public bool Update(stuManage.Model.Dormitory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Dormitory set ");
			if (model.num_occupants != null)
			{
				strSql.Append("num_occupants="+model.num_occupants+",");
			}
			if (model.live_num != null)
			{
				strSql.Append("live_num="+model.live_num+",");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where flo_num='"+ model.flo_num+"' and dor_num='"+ model.dor_num+"' ");
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
		public bool Delete(string flo_num,string dor_num)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Dormitory ");
			strSql.Append(" where flo_num='"+flo_num+"' and dor_num='"+dor_num+"' " );
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
		public stuManage.Model.Dormitory GetModel(string flo_num,string dor_num)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" flo_num,dor_num,num_occupants,live_num ");
			strSql.Append(" from Dormitory ");
			strSql.Append(" where flo_num='"+flo_num+"' and dor_num='"+dor_num+"' " );
			stuManage.Model.Dormitory model=new stuManage.Model.Dormitory();
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
		public stuManage.Model.Dormitory DataRowToModel(DataRow row)
		{
			stuManage.Model.Dormitory model=new stuManage.Model.Dormitory();
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
				if(row["num_occupants"]!=null && row["num_occupants"].ToString()!="")
				{
					model.num_occupants=int.Parse(row["num_occupants"].ToString());
				}
				if(row["live_num"]!=null && row["live_num"].ToString()!="")
				{
					model.live_num=int.Parse(row["live_num"].ToString());
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
			strSql.Append("select flo_num,dor_num,num_occupants,live_num ");
			strSql.Append(" FROM Dormitory ");
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
			strSql.Append(" flo_num,dor_num,num_occupants,live_num ");
			strSql.Append(" FROM Dormitory ");
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
			strSql.Append("select count(1) FROM Dormitory ");
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
				strSql.Append("order by T.dor_num desc");
			}
			strSql.Append(")AS Row, T.*  from Dormitory T ");
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

