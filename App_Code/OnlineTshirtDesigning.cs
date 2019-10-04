﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class admin
{
    public int AdminId { get; set; }
    public string AdminName { get; set; }
    public string AdminEmailAddr { get; set; }
    public string AdminPwd { get; set; }
    public string AdminRole { get; set; }
}

public partial class customer
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public customer()
    {
        this.customer_address = new HashSet<customer_address>();
        this.customer_product_cart = new HashSet<customer_product_cart>();
        this.product_order = new HashSet<product_order>();
    }

    public string CustId { get; set; }
    public string CustFirstName { get; set; }
    public string CustLastName { get; set; }
    public string CustPwd { get; set; }
    public Nullable<short> CustMobNo { get; set; }
    public string CustEmailAddr { get; set; }
    public string CustImg { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<customer_address> customer_address { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<customer_product_cart> customer_product_cart { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<product_order> product_order { get; set; }
}

public partial class customer_address
{
    public string CustAddrId { get; set; }
    public string CustShipAddr { get; set; }
    public string CustShipCountry { get; set; }
    public string CustShipState { get; set; }
    public string CustShipCity { get; set; }
    public Nullable<int> CustShipPinCode { get; set; }
    public string CustId { get; set; }

    public virtual customer customer { get; set; }
}

public partial class customer_product_cart
{
    public string CustCartId { get; set; }
    public short ProductId { get; set; }
    public string ProductCartId { get; set; }
    public string CustId { get; set; }

    public virtual customer customer { get; set; }
    public virtual product product { get; set; }
    public virtual product_cart product_cart { get; set; }
}

public partial class home_banner
{
    public int HomeImgId { get; set; }
    public byte[] HomeImg { get; set; }
    public string HomeBannerName { get; set; }
    public string HomeBannerDesc { get; set; }
    public string HomeBannerImgName { get; set; }
}

public partial class home_banner1
{
    public short BannerImgId { get; set; }
    public string BannerImg { get; set; }
    public string BannerName { get; set; }
    public string BannerDesc { get; set; }
    public string BannerImgName { get; set; }
}

public partial class inner_blogs
{
    public short InnerBlogsId { get; set; }
    public string InnerBlogsImg { get; set; }
    public string InnerBlogsImgName { get; set; }
    public string InnerBlogsName { get; set; }
    public string InnerBlogsDesc { get; set; }
}

public partial class product
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public product()
    {
        this.customer_product_cart = new HashSet<customer_product_cart>();
        this.product_cart = new HashSet<product_cart>();
        this.product_order = new HashSet<product_order>();
    }

    public short ProductId { get; set; }
    public string ProductCode { get; set; }
    public string ProductCat { get; set; }
    public string ProductName { get; set; }
    public string ProductStyle { get; set; }
    public string ProductColor { get; set; }
    public string ProductImg { get; set; }
    public string ProductDisc { get; set; }
    public Nullable<int> ProductPrice { get; set; }
    public string ProductNewArrival { get; set; }
    public Nullable<short> ProductSizeQuantM { get; set; }
    public Nullable<short> ProductSizeQuantXL { get; set; }
    public Nullable<short> ProductSizeQuantXXL { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<customer_product_cart> customer_product_cart { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<product_cart> product_cart { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<product_order> product_order { get; set; }
}

public partial class product_cart
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public product_cart()
    {
        this.customer_product_cart = new HashSet<customer_product_cart>();
    }

    public string ProductCartId { get; set; }
    public short ProductId { get; set; }
    public string SessionId { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<customer_product_cart> customer_product_cart { get; set; }
    public virtual product product { get; set; }
}

public partial class product_order
{
    public int ProductOrderId { get; set; }
    public System.DateTime ProductOrderTime { get; set; }
    public string ProductPaymentMthd { get; set; }
    public string CustComment { get; set; }
    public string CustId { get; set; }
    public short ProductId { get; set; }

    public virtual customer customer { get; set; }
    public virtual product product { get; set; }
}
