using System;
using System.Data;
using System.Collections.Generic;
using stuManage.Model;
using stuManage.DALFactory;
using stuManage.IDAL;
namespace stuManage.BLL
{
	/// <summary>
	/// Employee
	/// </summary>
	public partial class Employee
	{
		private readonly IEmployee dal=DataAccess.CreateEmployee();
		public Employee()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string emp_num)
		{
			return dal.Exists(emp_num);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(stuManage.Model.Employee model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(stuManage.Model.Employee model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string emp_num)
		{
			
			return dal.Delete(emp_num);
		}/*
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string emp_numlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(emp_numlist,0) );
		}*/

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public stuManage.Model.Employee GetModel(string emp_num)
		{
			
			return dal.GetModel(emp_num);
		}
        /*
		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public stuManage.Model.Employee GetModelByCache(string emp_num)
		{
			
			string CacheKey = "EmployeeModel-" + emp_num;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(emp_num);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (stuManage.Model.Employee)objModel;
		}
        */
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
		public List<stuManage.Model.Employee> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<stuManage.Model.Employee> DataTableToList(DataTable dt)
		{
			List<stuManage.Model.Employee> modelList = new List<stuManage.Model.Employee>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				stuManage.Model.Employee model;
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

