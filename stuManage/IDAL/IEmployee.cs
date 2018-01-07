using System;
using System.Data;
namespace stuManage.IDAL
{
	/// <summary>
	/// 接口层Employee
	/// </summary>
	public interface IEmployee
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(string emp_num);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		bool Add(stuManage.Model.Employee model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(stuManage.Model.Employee model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(string emp_num);
		bool DeleteList(string emp_numlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		stuManage.Model.Employee GetModel(string emp_num);
		stuManage.Model.Employee DataRowToModel(DataRow row);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		int GetRecordCount(string strWhere);
		DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法
		#region  MethodEx

		#endregion  MethodEx
	} 
}
