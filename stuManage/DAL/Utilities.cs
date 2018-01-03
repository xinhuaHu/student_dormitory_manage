using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using stuManage.IDAL;
using stuManage.DBUtility;
namespace stuManage.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Utilities
	/// </summary>
	public partial class Utilities:IUtilities
	{
		public Utilities()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(stuManage.Model.Utilities model)
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
			if (model.month_ != null)
			{
				strSql1.Append("month_,");
				strSql2.Append("'"+model.month_+"',");
			}
			if (model.electricity != null)
			{
				strSql1.Append("electricity,");
				strSql2.Append(""+model.electricity+",");
			}
			if (model.ele_fee != null)
			{
				strSql1.Append("ele_fee,");
				strSql2.Append(""+model.ele_fee+",");
			}
			if (model.water != null)
			{
				strSql1.Append("water,");
				strSql2.Append(""+model.water+",");
			}
			if (model.wat_fee != null)
			{
				strSql1.Append("wat_fee,");
				strSql2.Append(""+model.wat_fee+",");
			}
			strSql.Append("insert into Utilities(");
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
		public bool Update(stuManage.Model.Utilities model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Utilities set ");
			if (model.flo_num != null)
			{
				strSql.Append("flo_num='"+model.flo_num+"',");
			}
			if (model.dor_num != null)
			{
				strSql.Append("dor_num='"+model.dor_num+"',");
			}
			if (model.month_ != null)
			{
				strSql.Append("month_='"+model.month_+"',");
			}
			if (model.electricity != null)
			{
				strSql.Append("electricity="+model.electricity+",");
			}
			if (model.ele_fee != null)
			{
				strSql.Append("ele_fee="+model.ele_fee+",");
			}
			if (model.water != null)
			{
				strSql.Append("water="+model.water+",");
			}
			if (model.wat_fee != null)
			{
				strSql.Append("wat_fee="+model.wat_fee+",");
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
			strSql.Append("delete from Utilities ");
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
		public stuManage.Model.Utilities GetModel()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" flo_num,dor_num,month_,electricity,ele_fee,water,wat_fee ");
			strSql.Append(" from Utilities ");
			strSql.Append(" where " );
			stuManage.Model.Utilities model=new stuManage.Model.Utilities();
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
		public stuManage.Model.Utilities DataRowToModel(DataRow row)
		{
			stuManage.Model.Utilities model=new stuManage.Model.Utilities();
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
				if(row["month_"]!=null)
				{
					model.month_=row["month_"].ToString();
				}
				if(row["electricity"]!=null && row["electricity"].ToString()!="")
				{
					model.electricity=decimal.Parse(row["electricity"].ToString());
				}
				if(row["ele_fee"]!=null && row["ele_fee"].ToString()!="")
				{
					model.ele_fee=decimal.Parse(row["ele_fee"].ToString());
				}
				if(row["water"]!=null && row["water"].ToString()!="")
				{
					model.water=decimal.Parse(row["water"].ToString());
				}
				if(row["wat_fee"]!=null && row["wat_fee"].ToString()!="")
				{
					model.wat_fee=decimal.Parse(row["wat_fee"].ToString());
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
			strSql.Append("select flo_num,dor_num,month_,electricity,ele_fee,water,wat_fee ");
			strSql.Append(" FROM Utilities ");
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
			strSql.Append(" flo_num,dor_num,month_,electricity,ele_fee,water,wat_fee ");
			strSql.Append(" FROM Utilities ");
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
			strSql.Append("select count(1) FROM Utilities ");
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
				strSql.Append("order by T.num desc");
			}
			strSql.Append(")AS Row, T.*  from Utilities T ");
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

