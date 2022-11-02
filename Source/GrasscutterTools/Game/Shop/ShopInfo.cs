﻿/**
 *  Grasscutter Tools
 *  Copyright (C) 2022 jie65535
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Affero General Public License as published
 *  by the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Affero General Public License for more details.
 *
 *  You should have received a copy of the GNU Affero General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 * 
 **/
using System.Collections.Generic;

using Newtonsoft.Json;

namespace GrasscutterTools.Game.Shop
{
    public class ShopInfo
    {
        [JsonProperty("goodsId")]
        public int GoodsId { get; set; }

        [JsonProperty("goodsItem")]
        public ItemParamData GoodsItem { get; set; }

        /// <summary>
        /// 消耗摩拉
        /// </summary>
        [JsonProperty("scoin")]
        public int SCoin { get; set; }

        [JsonProperty("costItemList")]
        public List<ItemParamData> CostItemList { get; set; }

        [JsonProperty("boughtNum")]
        public int BoughtNum { get; set; }

        [JsonProperty("buyLimit")]
        public int BuyLimit { get; set; }

        [JsonProperty("beginTime")]
        public int BeginTime { get; set; }

        [JsonProperty("endTime")]
        public int EndTime { get; set; } = 1924992000;

        [JsonProperty("minLevel")]
        public int MinLevel { get; set; }

        [JsonProperty("maxLevel")]
        public int MaxLevel { get; set; } = 61;

        [JsonProperty("preGoodsIdList")]
        public List<int> PreGoodsIdList { get; set; }

        /// <summary>
        /// 消耗创世结晶
        /// </summary>
        [JsonProperty("mcoin")]
        public int MCoin { get; set; }

        /// <summary>
        /// 消耗原石
        /// </summary>

        [JsonProperty("hcoin")]
        public int HCoin { get; set; }

        [JsonProperty("disableType")]
        public int DisableType { get; set; }

        [JsonProperty("secondarySheetId")]
        public int SecondarySheetId { get; set; }

        [JsonProperty("refreshType")]
        public ShopRefreshType RefreshType { get; set; }

        [JsonProperty("shopRefreshParam")]
        public int ShopRefreshParam { get; set; }


        public override string ToString()
        {
            return $"{GoodsId}:{GameData.Items[GoodsItem.Id]} x{GoodsItem.Count}";
        }
    }
}
