﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using stuManage.IDAL;
using stuManage.DBUtility;
namespace stuManage.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Stustay
	/// </summary>
	public partial class Stustay:IStustay
	{
		public Stustay()
		{}
		#region  Method


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string num)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Stustay");
			strSql.Append(" where num='"+num+"' ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(stuManage.Model.Stustay model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Stustay(");
            strSql.Append("num,name,sex,profession,check_time,flo_num,dor_num)");
            strSql.Append(" values (");
            strSql.Append("@num,@name,@sex,@profession,@check_time,@flo_num,@dor_num)");
            SqlParameter[] parameters = {
					new SqlParameter("@num", SqlDbType.NVarChar,50),
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@sex", SqlDbType.NVarChar,50),
					new SqlParameter("@profession", SqlDbType.NVarChar,50),
					new SqlParameter("@check_time", SqlDbType.DateTime),
					new SqlParameter("@flo_num", SqlDbType.NVarChar,50),
					new SqlParameter("@dor_num", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.num;
            parameters[1].Value = model.name;
            parameters[2].Value = model.sex;
            parameters[3].Value = model.profession;
            parameters[4].Value = model.check_time;
            parameters[5].Value = model.flo_num;
            parameters[6].Value = model.dor_num;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
		public bool Update(stuManage.Model.Stustay model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Stustay set ");
			if (model.name != null)
			{
				strSql.Append("name='"+model.name+"',");
			}
			if (model.sex != null)
			{
				strSql.Append("sex='"+model.sex+"',");
			}
			else
			{
				strSql.Append("sex= null ,");
			}
			if (model.profession != null)
			{
				strSql.Append("profession='"+model.profession+"',");
			}
			if (model.check_time != null)
			{
				strSql.Append("check_time='"+model.check_time+"',");
			}
			if (model.flo_num != null)
			{
				strSql.Append("flo_num='"+model.flo_num+"',");
			}
			if (model.dor_num != null)
			{
				strSql.Append("dor_num='"+model.dor_num+"',");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where num='"+ model.num+"' ");
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
		public bool Delete(string num)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Stustay ");
			strSql.Append(" where num='"+num+"' " );
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
		public bool DeleteList(string numlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Stustay ");
			strSql.Append(" where num in ("+numlist + ")  ");
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
		public stuManage.Model.Stustay GetModel(string num)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" num,name,sex,profession,check_time,flo_num,dor_num ");
			strSql.Append(" from Stustay ");
			strSql.Append(" where num='"+num+"' " );
			stuManage.Model.Stustay model=new stuManage.Model.Stustay();
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
		public stuManage.Model.Stustay DataRowToModel(DataRow row)
		{
			stuManage.Model.Stustay model=new stuManage.Model.Stustay();
			if (row != null)
			{
				if(row["num"]!=null)
				{
					model.num=row["num"].ToString();
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["sex"]!=null)
				{
					model.sex=row["sex"].ToString();
				}
				if(row["profession"]!=null)
				{
					model.profession=row["profession"].ToString();
				}
				if(row["check_time"]!=null && row["check_time"].ToString()!="")
				{
					model.check_time=DateTime.Parse(row["check_time"].ToString());
				}
				if(row["flo_num"]!=null)
				{
					model.flo_num=row["flo_num"].ToString();
				}
				if(row["dor_num"]!=null)
				{
					model.dor_num=row["dor_num"].ToString();
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
			strSql.Append("select num,name,sex,profession,check_time,flo_num,dor_num ");
			strSql.Append(" FROM Stustay ");
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
			strSql.Append(" num,name,sex,profession,check_time,flo_num,dor_num ");
			strSql.Append(" FROM Stustay ");
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
			strSql.Append("select count(1) FROM Stustay ");
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
			strSql.Append(")AS Row, T.*  from Stustay T ");
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

