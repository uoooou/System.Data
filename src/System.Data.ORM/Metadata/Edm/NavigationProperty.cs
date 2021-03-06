﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.Metadata.Edm {

    public sealed class NavigationProperty : EdmMember {

        private RelationshipType _relationshipType;
        /// <summary>
        /// 返回/设置 属性使用的关系。
        /// </summary>
        public RelationshipType RelationshipType {
            get { return _relationshipType; }
            set { _relationshipType = value; }
        }

        //todo:方向：正向访问还是反向访问 正向是一对多，反向是一对一
        //todo:多对多怎么办？
    }
}
