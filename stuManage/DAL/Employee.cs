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
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string emp_num)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Employee");
			strSql.Append(" where emp_num='"+emp_num+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(stuManage.Model.Employee model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.emp_num != null)
			{
				strSql1.Append("emp_num,");
				strSql2.Append("'"+model.emp_num+"',");
			}
			if (model.emp_name != null)
			{
				strSql1.Append("emp_name,");
				strSql2.Append("'"+model.emp_name+"',");
			}
			if (model.emp_passwd != null)
			{
				strSql1.Append("emp_passwd,");
				strSql2.Append("'"+model.emp_passwd+"',");
			}
			if (model.emp_age != null)
			{
				strSql1.Append("emp_age,");
				strSql2.Append(""+model.emp_age+",");
			}
			if (model.flo_num != null)
			{
				strSql1.Append("flo_num,");
				strSql2.Append("'"+model.flo_num+"',");
			}
			if (model.emp_sex != null)
			{
				strSql1.Append("emp_sex,");
				strSql2.Append("'"+model.emp_sex+"',");
			}
			if (model.con_infor != null)
			{
				strSql1.Append("con_infor,");
				strSql2.Append("'"+model.con_infor+"',");
			}
			strSql.Append("insert into Employee(");
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
		public bool Update(stuManage.Model.Employee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Employee set ");
			if (model.emp_name != null)
			{
				strSql.Append("emp_name='"+model.emp_name+"',");
			}
			if (model.emp_passwd != null)
			{
				strSql.Append("emp_passwd='"+model.emp_passwd+"',");
			}
			if (model.emp_age != null)
			{
				strSql.Append("emp_age="+model.emp_age+",");
			}
			else
			{
				strSql.Append("emp_age= null ,");
			}
			if (model.flo_num != null)
			{
				strSql.Append("flo_num='"+model.flo_num+"',");
			}
			else
			{
				strSql.Append("flo_num= null ,");
			}
			if (model.emp_sex != null)
			{
				strSql.Append("emp_sex='"+model.emp_sex+"',");
			}
			else
			{
				strSql.Append("emp_sex= null ,");
			}
			if (model.con_infor != null)
			{
				strSql.Append("con_infor='"+model.con_infor+"',");
			}
			else
			{
				strSql.Append("con_infor= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where emp_num='"+ model.emp_num+"' ");
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
		public bool Delete(string emp_num)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Employee ");
			strSql.Append(" where emp_num='"+emp_num+"' " );
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}		/// <summary>
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
			strSql.Append("select  top 1  ");
			strSql.Append(" emp_num,emp_name,emp_passwd,emp_age,flo_num,emp_sex,con_infor ");
			strSql.Append(" from Employee ");
			strSql.Append(" where emp_num='"+emp_num+"' " );
			stuManage.Model.Employee model=new stuManage.Model.Employee();
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
				if(row["emp_age"]!=null && row["emp_age"].ToString()!="")
				{
					model.emp_age=int.Parse(row["emp_age"].ToString());
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
		*/

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

