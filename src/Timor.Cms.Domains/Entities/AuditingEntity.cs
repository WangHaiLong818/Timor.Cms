﻿using System;
using MongoDB.Bson;
using Timor.Cms.Domains.Users;

namespace Timor.Cms.Domains.Entities
{
    public abstract class AuditingEntity : AuditingEntity<ObjectId>
    {

    }

    public abstract class AuditingEntity<TPrimaryKey> : Entity<TPrimaryKey>, ISoftDelete
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public User CreateUser { get; set; }

        /// <summary>
        /// 最后更改时间
        /// </summary>
        public DateTime? LastModifyTime { get; set; }

        /// <summary>
        /// 最后更改用户
        /// </summary>
        public User LastModifyUser { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? DeleteTime { get; set; }

        /// <summary>
        /// 删除用户
        /// </summary>
        public User DeleteUser { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
