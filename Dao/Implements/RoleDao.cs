using System.Data;
using VStay_Backend.Dao.Base;
using VStay_Backend.Dao.Interfaces;
using VStay_Backend.Models.Entities;

namespace VStay_Backend.Dao.Implements
{
    /// <summary>
    /// The permission dao object to access database to handle role table.
    /// </summary>
    public class RoleDao : BaseDao<RoleEntity>, IRoleDao
    {
        #region Constructor

        public RoleDao() : base()
        {
            StoredProcedureInsert = "[VSTAY].[usp_Role_Insert]";
            StoredProcedureGet = "[VSTAY].[usp_Role_Get]";
            StoredProcedureList = "[VSTAY].[usp_Role_List]";
            StoredProcedureUpdate = "[VSTAY].[usp_Role_Update]";
            StoredProcedureDelete = "[VSTAY].[usp_Role_Delete]";
        }

        #endregion

        /// <inheritdoc/>
        public override RoleEntity ConvertDataRowToEntity(DataRow dataRow)
        {
            return new RoleEntity(dataRow);
        }

        #region Custom Method
        #endregion
    }
}
