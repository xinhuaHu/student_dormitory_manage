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
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string number)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Utilities");
			strSql.Append(" where number=@number ");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50)			};
			parameters[0].Value = number;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(stuManage.Model.Utilities model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Utilities(");
			strSql.Append("number,flo_num,dor_num,month_,electricity,ele_fee,water,wat_fee)");
			strSql.Append(" values (");
			strSql.Append("@number,@flo_num,@dor_num,@month_,@electricity,@ele_fee,@water,@wat_fee)");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@flo_num", SqlDbType.Char,10),
					new SqlParameter("@dor_num", SqlDbType.Char,10),
					new SqlParameter("@month_", SqlDbType.VarChar,4),
					new SqlParameter("@electricity", SqlDbType.Char,10),
					new SqlParameter("@ele_fee", SqlDbType.Char,10),
					new SqlParameter("@water", SqlDbType.Char,10),
					new SqlParameter("@wat_fee", SqlDbType.Char,10)};
			parameters[0].Value = model.number;
			parameters[1].Value = model.flo_num;
			parameters[2].Value = model.dor_num;
			parameters[3].Value = model.month_;
			parameters[4].Value = model.electricity;
			parameters[5].Value = model.ele_fee;
			parameters[6].Value = model.water;
			parameters[7].Value = model.wat_fee;

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
		public bool Update(stuManage.Model.Utilities model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Utilities set ");
			strSql.Append("flo_num=@flo_num,");
			strSql.Append("dor_num=@dor_num,");
			strSql.Append("month_=@month_,");
			strSql.Append("electricity=@electricity,");
			strSql.Append("ele_fee=@ele_fee,");
			strSql.Append("water=@water,");
			strSql.Append("wat_fee=@wat_fee");
			strSql.Append(" where number=@number ");
			SqlParameter[] parameters = {
					new SqlParameter("@flo_num", SqlDbType.Char,10),
					new SqlParameter("@dor_num", SqlDbType.Char,10),
					new SqlParameter("@month_", SqlDbType.VarChar,4),
					new SqlParameter("@electricity", SqlDbType.Char,10),
					new SqlParameter("@ele_fee", SqlDbType.Char,10),
					new SqlParameter("@water", SqlDbType.Char,10),
					new SqlParameter("@wat_fee", SqlDbType.Char,10),
					new SqlParameter("@number", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.flo_num;
			parameters[1].Value = model.dor_num;
			parameters[2].Value = model.month_;
			parameters[3].Value = model.electricity;
			parameters[4].Value = model.ele_fee;
			parameters[5].Value = model.water;
			parameters[6].Value = model.wat_fee;
			parameters[7].Value = model.number;

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
		public bool Delete(string number)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Utilities ");
			strSql.Append(" where number=@number ");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50)			};
			parameters[0].Value = number;

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
		public bool DeleteList(string numberlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Utilities ");
			strSql.Append(" where number in ("+numberlist + ")  ");
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
		public stuManage.Model.Utilities GetModel(string number)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 number,flo_num,dor_num,month_,electricity,ele_fee,water,wat_fee from Utilities ");
			strSql.Append(" where number=@number ");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50)			};
			parameters[0].Value = number;

			stuManage.Model.Utilities model=new stuManage.Model.Utilities();
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
		public stuManage.Model.Utilities DataRowToModel(DataRow row)
		{
			stuManage.Model.Utilities model=new stuManage.Model.Utilities();
			if (row != null)
			{
				if(row["number"]!=null)
				{
					model.number=row["number"].ToString();
				}
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
				if(row["electricity"]!=null)
				{
					model.electricity=row["electricity"].ToString();
				}
				if(row["ele_fee"]!=null)
				{
					model.ele_fee=row["ele_fee"].ToString();
				}
				if(row["water"]!=null)
				{
					model.water=row["water"].ToString();
				}
				if(row["wat_fee"]!=null)
				{
					model.wat_fee=row["wat_fee"].ToString();
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
			strSql.Append("select number,flo_num,dor_num,month_,electricity,ele_fee,water,wat_fee ");
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
			strSql.Append(" number,flo_num,dor_num,month_,electricity,ele_fee,water,wat_fee ");
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
				strSql.Append("order by T.number desc");
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
			parameters[0].Value = "Utilities";
			parameters[1].Value = "number";
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

