using System;
using System.Collections.Generic;
using System.Text;

namespace TheCloudBill.Application.Common.Dto.Base
{
    public class EntityDto<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }

    }
}
