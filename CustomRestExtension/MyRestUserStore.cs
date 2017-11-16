﻿using System.Threading.Tasks;
using CustomRestExtension.Model;
using Mongoose.Common.Api;

namespace CustomRestExtension
{
    /// <summary>
    /// This class works in cooperation with the 
    /// </summary>
    public class MyRestUserStore : RestUserStoreBase<MyUser, string>
    {
        #region Constructor
        public MyRestUserStore()
        {
        }
        #endregion

        #region FindByIdAsync - Override
        /// <inheritdoc />
        public override Task<MyUser> FindByIdAsync(string userId)
        {
            // We just dummy up a user
            return Task.FromResult(new MyUser { UserName = userId });

        }
        #endregion
        #region FindByNameAsync - Override
        /// <inheritdoc />
        public override Task<MyUser> FindByNameAsync(string userName)
        {
            // We just dummy up a user
            return Task.FromResult(new MyUser { UserName = userName });
        }
        #endregion
    }
}