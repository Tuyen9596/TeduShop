namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        StackTrace = c.String(),
                        CreateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Footer",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MenuGroup",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        URL = c.String(nullable: false),
                        GroupID = c.Int(nullable: false),
                        DIsplayOrder = c.Int(),
                        Target = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MenuGroup", t => t.GroupID, cascadeDelete: true)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        Quatity = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Orders", t => t.OrderID)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.Binary(nullable: false),
                        Message = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        CreateBy = c.String(nullable: false),
                        PayMentMeThod = c.String(nullable: false),
                        PayMentStatus = c.String(nullable: false),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Alas = c.String(nullable: false),
                        CategoryID = c.Int(),
                        Image = c.String(),
                        MoreImage = c.String(storeType: "xml"),
                        Price = c.Int(nullable: false),
                        PromotionPrice = c.Decimal(precision: 18, scale: 2),
                        Waranty = c.Int(),
                        Description = c.String(nullable: false),
                        MetaKeyword = c.String(nullable: false),
                        MetaDescription = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(),
                        Status = c.Boolean(nullable: false),
                        HomeFlag = c.Boolean(),
                        ViewCount = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProductCategories", t => t.CategoryID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Alas = c.String(nullable: false),
                        ParentID = c.Int(),
                        Image = c.String(),
                        Description = c.String(),
                        DisplayOder = c.Int(),
                        MetaKeyword = c.String(),
                        MetaDescription = c.String(),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(),
                        Status = c.Boolean(nullable: false),
                        HomeFlag = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Name = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Post",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Alas = c.String(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        Image = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        MetaKeyword = c.String(nullable: false),
                        MetaDescription = c.String(),
                        Content = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreateBy = c.String(),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(),
                        Status = c.Boolean(),
                        HomeFlag = c.Boolean(),
                        ViewCount = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PostCategories", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.PostCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PostName = c.String(nullable: false),
                        Alas = c.String(nullable: false),
                        ParentID = c.Int(nullable: false),
                        Image = c.String(),
                        Description = c.String(),
                        DisplayOder = c.Int(nullable: false),
                        MetaKeyword = c.String(),
                        MetaDescription = c.String(),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(),
                        Status = c.Boolean(nullable: false),
                        HomeFlag = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        TagID = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PostID);
            
            CreateTable(
                "dbo.ProductTags",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.ProductID, t.TagID })
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(maxLength: 256),
                        Image = c.String(maxLength: 256),
                        URL = c.String(maxLength: 256),
                        DisplayOrder = c.Int(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SupportOnlines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Department = c.String(),
                        Skype = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Yahoo = c.String(),
                        Facebook = c.String(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SystemConfigs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        ValueString = c.String(),
                        ValueInt = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        VisitedDate = c.DateTime(nullable: false),
                        IPAddress = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PostTag1",
                c => new
                    {
                        Post_ID = c.Int(nullable: false),
                        Tag_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.Post_ID, t.Tag_ID })
                .ForeignKey("dbo.Post", t => t.Post_ID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.Tag_ID, cascadeDelete: true)
                .Index(t => t.Post_ID)
                .Index(t => t.Tag_ID);
            
            CreateTable(
                "dbo.TagProducts",
                c => new
                    {
                        Tag_ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Product_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_ID, t.Product_ID })
                .ForeignKey("dbo.Tags", t => t.Tag_ID, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.Product_ID, cascadeDelete: true)
                .Index(t => t.Tag_ID)
                .Index(t => t.Product_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.ProductTags", "ProductID", "dbo.Product");
            DropForeignKey("dbo.TagProducts", "Product_ID", "dbo.Product");
            DropForeignKey("dbo.TagProducts", "Tag_ID", "dbo.Tags");
            DropForeignKey("dbo.PostTag1", "Tag_ID", "dbo.Tags");
            DropForeignKey("dbo.PostTag1", "Post_ID", "dbo.Post");
            DropForeignKey("dbo.Post", "ID", "dbo.PostCategories");
            DropForeignKey("dbo.Product", "CategoryID", "dbo.ProductCategories");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Product");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Menus", "GroupID", "dbo.MenuGroup");
            DropIndex("dbo.TagProducts", new[] { "Product_ID" });
            DropIndex("dbo.TagProducts", new[] { "Tag_ID" });
            DropIndex("dbo.PostTag1", new[] { "Tag_ID" });
            DropIndex("dbo.PostTag1", new[] { "Post_ID" });
            DropIndex("dbo.ProductTags", new[] { "TagID" });
            DropIndex("dbo.ProductTags", new[] { "ProductID" });
            DropIndex("dbo.Post", new[] { "ID" });
            DropIndex("dbo.Product", new[] { "CategoryID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Menus", new[] { "GroupID" });
            DropTable("dbo.TagProducts");
            DropTable("dbo.PostTag1");
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.SystemConfigs");
            DropTable("dbo.SupportOnlines");
            DropTable("dbo.Slides");
            DropTable("dbo.ProductTags");
            DropTable("dbo.PostTags");
            DropTable("dbo.Pages");
            DropTable("dbo.PostCategories");
            DropTable("dbo.Post");
            DropTable("dbo.Tags");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Product");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Menus");
            DropTable("dbo.MenuGroup");
            DropTable("dbo.Footer");
            DropTable("dbo.Errors");
        }
    }
}
