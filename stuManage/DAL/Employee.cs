using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using stuManage.IDAL;
using stuManage.DBUtility;
namespace stuManage.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Employee
	/// </summary>
	public partial class Employee:IEmployee
	{
		public Employee()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string emp_num)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Employee");
			strSql.Append(" where emp_num=@emp_num ");
			SqlParameter[] parameters = {
					new SqlParameter("@emp_num", SqlDbType.Char,10)			};
			parameters[0].Value = emp_num;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(stuManage.Model.Employee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Employee(");
			strSql.Append("emp_num,emp_name,emp_passwd,emp_age,flo_num,emp_sex,con_infor)");
			strSql.Append(" values (");
			strSql.Append("@emp_num,@emp_name,@emp_passwd,@emp_age,@flo_num,@emp_sex,@con_infor)");
			SqlParameter[] parameters = {
					new SqlParameter("@emp_num", SqlDbType.Char,10),
					new SqlParameter("@emp_name", SqlDbType.VarChar,10),
					new SqlParameter("@emp_passwd", SqlDbType.VarChar,20),
					new SqlParameter("@emp_age", SqlDbType.Char,10),
					new SqlParameter("@flo_num", SqlDbType.Char,10),
					new SqlParameter("@emp_sex", SqlDbType.Char,2),
					new SqlParameter("@con_infor", SqlDbType.Char,11)};
			parameters[0].Value = model.emp_num;
			parameters[1].Value = model.emp_name;
			parameters[2].Value = model.emp_passwd;
			parameters[3].Value = model.emp_age;
			parameters[4].Value = model.flo_num;
			parameters[5].Value = model.emp_sex;
			parameters[6].Value = model.con_infor;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(stuManage.Model.Employee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Employee set ");
			strSql.Append("emp_name=@emp_name,");
			strSql.Append("emp_passwd=@emp_passwd,");
			strSql.Append("emp_age=@emp_age,");
			strSql.Append("flo_num=@flo_num,");
			strSql.Append("emp_sex=@emp_sex,");
			strSql.Append("con_infor=@con_infor");
			strSql.Append(" where emp_num=@emp_num ");
			SqlParameter[] parameters = {
					new SqlParameter("@emp_name", SqlDbType.VarChar,10),
					new SqlParameter("@emp_passwd", SqlDbType.VarChar,20),
					new SqlParameter("@emp_age", SqlDbType.Char,10),
					new SqlParameter("@flo_num", SqlDbType.Char,10),
					new SqlParameter("@emp_sex", SqlDbType.Char,2),
					new SqlParameter("@con_infor", SqlDbType.Char,11),
					new SqlParameter("@emp_num", SqlDbType.Char,10)};
			parameters[0].Value = model.emp_name;
			parameters[1].Value = model.emp_passwd;
			parameters[2].Value = model.emp_age;
			parameters[3].Value = model.flo_num;
			parameters[4].Value = model.emp_sex;
			parameters[5].Value = model.con_infor;
			parameters[6].Value = model.emp_num;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(string emp_num)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Employee ");
			strSql.Append(" where emp_num=@emp_num ");
			SqlParameter[] parameters = {
					new SqlParameter("@emp_num", SqlDbType.Char,10)			};
			parameters[0].Value = emp_num;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string emp_numlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Employee ");
			strSql.Append(" where emp_num in ("+emp_numlist + ")  ");
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
		/// 得到一个对象实体
		/// </summary>
		public stuManage.Model.Employee GetModel(string emp_num)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 emp_num,emp_name,emp_passwd,emp_age,flo_num,emp_sex,con_infor from Employee ");
			strSql.Append(" where emp_num=@emp_num ");
			SqlParameter[] parameters = {
					new SqlParameter("@emp_num", SqlDbType.Char,10)			};
			parameters[0].Value = emp_num;

			stuManage.Model.Employee model=new stuManage.Model.Employee();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
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
		public stuManage.Model.Employee DataRowToModel(DataRow row)
		{
			stuManage.Model.Employee model=new stuManage.Model.Employee();
			if (row != null)
			{
				if(row["emp_num"]!=null)
				{
					model.emp_num=row["emp_num"].ToString();
				}
				if(row["emp_name"]!=null)
				{
					model.emp_name=row["emp_name"].ToString();
				}
				if(row["emp_passwd"]!=null)
				{
					model.emp_passwd=row["emp_passwd"].ToString();
				}
				if(row["emp_age"]!=null)
				{
					model.emp_age=row["emp_age"].ToString();
				}
				if(row["flo_num"]!=null)
				{
					model.flo_num=row["flo_num"].ToString();
				}
				if(row["emp_sex"]!=null)
				{
					model.emp_sex=row["emp_sex"].ToString();
				}
				if(row["con_infor"]!=null)
				{
					model.con_infor=row["con_infor"].ToString();
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
			strSql.Append("select emp_num,emp_name,emp_passwd,emp_age,flo_num,emp_sex,con_infor ");
			strSql.Append(" FROM Employee ");
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
			strSql.Append(" emp_num,emp_name,emp_passwd,emp_age,flo_num,emp_sex,con_infor ");
			strSql.Append(" FROM Employee ");
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
			strSql.Append("select count(1) FROM Employee ");
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
			strSql.Append(")AS Row, T.*  from Employee T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Employee";
			parameters[1].Value = "emp_num";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

