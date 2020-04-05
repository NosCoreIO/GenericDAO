﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// 

using System.ComponentModel.DataAnnotations;

namespace NosCore.Dao.Tests.TestsModels
{
    public class CompositeEntity
    {

        public int Key1 { get; set; }

        public int Key2 { get; set; }

        public string? Value { get; set; }
    }
}