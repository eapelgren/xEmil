﻿using System;
using System.Collections.Generic;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using XLabs.Ioc;

namespace xEmilForms.ViewModels
{
    public class ScrollPageViewModel : BindableBase
    {
        private List<CellData> _cellDataList;

        public List<CellData> CellDataList
        {
            get { return _cellDataList ?? (_cellDataList = CreateCellData()); }
            set { SetProperty(ref _cellDataList, value); }
        }

        private List<CellData> CreateCellData()
        {
            var list = new List<CellData>
            {
                  new ImageCellData("1")
                  {
                      ImageUrl = "https://images-na.ssl-images-amazon.com/images/G/01/img15/pet-products/small-tiles/30423_pets-products_january-site-flip_3-cathealth_short-tile_592x304._CB286975940_.jpg"
                  },
                  new ImageCellData("2")
                  {
                      ImageUrl = "https://img1.wsimg.com/fos/sales/cwh/8/images/cats-with-hats-shop-02.jpg"
                  },
                  new ImageCellData("3")
                  {
                      ImageUrl = "https://i.ytimg.com/vi/tntOCGkgt98/maxresdefault.jpg"
                  },
                  new ImageCellData("4")
                  {
                      ImageUrl = "https://images-na.ssl-images-amazon.com/images/G/01/img15/pet-products/small-tiles/30423_pets-products_january-site-flip_3-cathealth_short-tile_592x304._CB286975940_.jpg"
                  },
                  //new ImageCellData()
                  //{
                  //    ImageUrl = "https://img1.wsimg.com/fos/sales/cwh/8/images/cats-with-hats-shop-02.jpg"
                  //},
                  //new ImageCellData()
                  //{
                  //    ImageUrl = "https://i.ytimg.com/vi/tntOCGkgt98/maxresdefault.jpg"
                  //},
                  //new ImageCellData()
                  //{
                  //    ImageUrl = "https://images-na.ssl-images-amazon.com/images/G/01/img15/pet-products/small-tiles/30423_pets-products_january-site-flip_3-cathealth_short-tile_592x304._CB286975940_.jpg"
                  //},
                  //new ImageCellData()
                  //{
                  //    ImageUrl = "https://img1.wsimg.com/fos/sales/cwh/8/images/cats-with-hats-shop-02.jpg"
                  //},
                  //new ImageCellData()
                  //{
                  //    ImageUrl = "https://i.ytimg.com/vi/tntOCGkgt98/maxresdefault.jpg"
                  //},

            };
            return list;
        }
    }
}