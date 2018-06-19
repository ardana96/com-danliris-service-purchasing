﻿using Com.DanLiris.Service.Purchasing.Lib.Models.ExternalPurchaseOrderModel;
using Com.DanLiris.Service.Purchasing.Lib.Utilities;
using Com.DanLiris.Service.Purchasing.Lib.ViewModels.ExternalPurchaseOrderViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.DanLiris.Service.Purchasing.Lib.AutoMapperProfiles
{
    public class ExternalPurchaseOrderProfile : BaseAutoMapperProfile
    {
        public ExternalPurchaseOrderProfile()
        {
            CreateMap<ExternalPurchaseOrderDetail, ExternalPurchaseOrderDetailViewModel>()
                .ForPath(d => d.product._id, opt => opt.MapFrom(s => s.ProductId))
                .ForPath(d => d.product.code, opt => opt.MapFrom(s => s.ProductCode))
                .ForPath(d => d.product.name, opt => opt.MapFrom(s => s.ProductName))
                .ForPath(d => d.product.uom.unit, opt => opt.MapFrom(s => s.DefaultUomUnit))
                .ForPath(d => d.product.uom._id, opt => opt.MapFrom(s => s.DefaultUomId))
                .ForPath(d => d.dealUom._id, opt => opt.MapFrom(s => s.DealUomId))
                .ForPath(d => d.dealUom.unit, opt => opt.MapFrom(s => s.DealUomUnit))
                .ReverseMap();

            CreateMap<ExternalPurchaseOrder, ExternalPurchaseOrderViewModel>()
                /* Unit */
                .ForPath(d => d.unit._id, opt => opt.MapFrom(s => s.UnitId))
                .ForPath(d => d.unit.code, opt => opt.MapFrom(s => s.UnitCode))
                .ForPath(d => d.unit.name, opt => opt.MapFrom(s => s.UnitName))
                /* Division */
                .ForPath(d => d.unit.division._id, opt => opt.MapFrom(s => s.DivisionId))
                .ForPath(d => d.unit.division.code, opt => opt.MapFrom(s => s.DivisionCode))
                .ForPath(d => d.unit.division.name, opt => opt.MapFrom(s => s.DivisionName))
                /* Supplier */
                .ForPath(d => d.supplier._id, opt => opt.MapFrom(s => s.SupplierId))
                .ForPath(d => d.supplier.code, opt => opt.MapFrom(s => s.SupplierCode))
                .ForPath(d => d.supplier.name, opt => opt.MapFrom(s => s.SupplierName))
                /* Currency */
                .ForPath(d => d.currency._id, opt => opt.MapFrom(s => s.CurrencyId))
                .ForPath(d => d.currency.code, opt => opt.MapFrom(s => s.CurrencyCode))
                .ForPath(d => d.currency.rate, opt => opt.MapFrom(s => s.CurrencyRate))
                /* Vat */
                .ForPath(d => d.vat._id, opt => opt.MapFrom(s => s.VatId))
                .ForPath(d => d.vat.name, opt => opt.MapFrom(s => s.VatName))
                .ForPath(d => d.vat.rate, opt => opt.MapFrom(s => s.VatRate))

                .ForPath(d => d.no, opt => opt.MapFrom(s => s.EPONo))
                .ForMember(d => d.items, opt => opt.MapFrom(s => s.Items))
                .ReverseMap();

            CreateMap<ExternalPurchaseOrderItem, ExternalPurchaseOrderItemViewModel>()
                /* Unit */
                .ForPath(d => d.unit._id, opt => opt.MapFrom(s => s.UnitId))
                .ForPath(d => d.unit.code, opt => opt.MapFrom(s => s.UnitCode))
                .ForPath(d => d.unit.name, opt => opt.MapFrom(s => s.UnitName))
                .ForMember(d => d.details, opt => opt.MapFrom(s => s.Details))
                .ReverseMap();
        }
    }
}
