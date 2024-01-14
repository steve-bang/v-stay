using System.Data;
using VStay_Backend.Dao.Base;
using VStay_Backend.Dao.Interfaces;
using VStay_Backend.Models.Entities;

namespace VStay_Backend.Dao.Implements
{
    /// <summary>
    /// The permission dao object to access database to handle permission table.
    /// </summary>
    public class PermissionDao : BaseDao<PermissionEntity>, IPermissionDao
    {
        #region Constructor

        public PermissionDao() : base() 
        {
            StoredProcedureInsert = "[VSTAY].[usp_Permission_Insert]";
            StoredProcedureGet = "[VSTAY].[usp_Permission_Get]";
            StoredProcedureList = "[VSTAY].[usp_Permission_List]";
            StoredProcedureUpdate = "[VSTAY].[usp_Permission_Update]";
            StoredProcedureDelete = "[VSTAY].[usp_Permission_Delete]";
        }

        #endregion

        /// <inheritdoc/>
        public override PermissionEntity ConvertDataRowToEntity(DataRow dataRow)
        {
            return new PermissionEntity(dataRow);
        }


        #region Custom Method
        #endregion
    }
}
