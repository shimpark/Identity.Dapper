﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Dapper.Entities
{
    public class DapperIdentityUserLogin<TKey> where TKey : IEquatable<TKey>
    {
        public virtual string LoginProvider { get; set; }
        public virtual string ProviderKey { get; set; }
        public virtual string ProviderDisplayName { get; set; }
        public virtual TKey UserId { get; set; }
    }
}
