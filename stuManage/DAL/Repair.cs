using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using stuManage.IDAL;
using stuManage.DBUtility;
//using stuManage.DBUtility;//Please add references
namespace stuManage.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Repair
	/// </summary>
	public partial class Repair:IRepair
	{
		public Repair()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(stuManage.Model.Repair model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Repair(");
			strSql.Append("flo_num,dor_num,art_num,repa_rea,sub_date,sol_date,repa_fee)");
			strSql.Append(" values (");
			strSql.Append("@flo_num,@dor_num,@art_num,@repa_rea,@sub_date,@sol_date,@repa_fee)");
			SqlParameter[] parameters = {
					new SqlParameter("@flo_num", SqlDbType.Char,10),
					new SqlParameter("@dor_num", SqlDbType.Char,10),
					new SqlParameter("@art_num", SqlDbType.Char,8),
					new SqlParameter("@repa_rea", SqlDbType.Char,50),
					new SqlParameter("@sub_date", SqlDbType.DateTime),
					new SqlParameter("@sol_date", SqlDbType.DateTime),
					new SqlParameter("@repa_fee", SqlDbType.Decimal,5)};
			parameters[0].Value = model.flo_num;
			parameters[1].Value = model.dor_num;
			parameters[2].Value = model.art_num;
			parameters[3].Value = model.repa_rea;
			parameters[4].Value = model.sub_date;
			parameters[5].Value = model.sol_date;
			parameters[6].Value = model.repa_fee;

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
		public bool Update(stuManage.Model.Repair model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Repair set ");
			strSql.Append("flo_num=@flo_num,");
			strSql.Append("dor_num=@dor_num,");
			strSql.Append("art_num=@art_num,");
			strSql.Append("repa_rea=@repa_rea,");
			strSql.Append("sub_date=@sub_date,");
			strSql.Append("sol_date=@sol_date,");
			strSql.Append("repa_fee=@repa_fee");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@flo_num", SqlDbType.Char,10),
					new SqlParameter("@dor_num", SqlDbType.Char,10),
					new SqlParameter("@art_num", SqlDbType.Char,8),
					new SqlParameter("@repa_rea", SqlDbType.Char,50),
					new SqlParameter("@sub_date", SqlDbType.DateTime),
					new SqlParameter("@sol_date", SqlDbType.DateTime),
					new SqlParameter("@repa_fee", SqlDbType.Decimal,5)};
			parameters[0].Value = model.flo_num;
			parameters[1].Value = model.dor_num;
			parameters[2].Value = model.art_num;
			parameters[3].Value = model.repa_rea;
			parameters[4].Value = model.sub_date;
			parameters[5].Value = model.sol_date;
			parameters[6].Value = model.repa_fee;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Repair ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public stuManage.Model.Repair GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 flo_num,dor_num,art_num,repa_rea,sub_date,sol_date,repa_fee from Repair ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			stuManage.Model.Repair model=new stuManage.Model.Repair();
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
			parameters[0].Value = "Repair";
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

