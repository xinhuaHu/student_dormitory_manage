﻿using System.Data;
using System.Collections.Generic;
using stuManage.DALFactory;
using stuManage.IDAL;
namespace stuManage.BLL
{
	/// <summary>
	/// Utilities
	/// </summary>
	public partial class Utilities
	{
		private readonly IUtilities dal=DataAccess.CreateUtilities();
		public Utilities()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string number)
		{
			return dal.Exists(number);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(stuManage.Model.Utilities model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(stuManage.Model.Utilities model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string number)
		{
			
			return dal.Delete(number);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public stuManage.Model.Utilities GetModel(string number)
		{
			
			return dal.GetModel(number);
		}
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<stuManage.Model.Utilities> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<stuManage.Model.Utilities> DataTableToList(DataTable dt)
		{
			List<stuManage.Model.Utilities> modelList = new List<stuManage.Model.Utilities>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				stuManage.Model.Utilities model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

