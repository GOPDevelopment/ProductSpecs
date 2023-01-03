Public Class AllClasses

    'Select Case PC_ID, ProductCode, [Main Code], [Grade/Brand], [Grade Abbreviation], [Cut Type (BI/Bnls)], [Product Description], [Product Description (Alpha)], [Pc/Bag], [Bag/Box], [Pc/Box], [Hd/Box], [Weight Classification], 
    '                     [Gross Wt], [Net Wt], [Domestic Shelf Life Fresh], [Domestic Shelf Life Frozen], [Export Shelf Life Fresh], [Export Shelf LifeFrozen], BoxID, Primary_BagId, Secondary_BagID, DTS
    'FROM            dbo.ProductInfo



    'tied to ProductInfo
    'SELECT        BoxID, Department, Box_Descr, Box_Brand, Box_Print_Color, Style, Board_Descr, Board_Combo, Box_Blank_Size, [Box_Inner_Length (inches)], [Box_Inner_Width (inches)], [Box_Inner_Height (inches)], 
    'Box_Inner_Dims, Box_Outer_Dims, Box_Cube_Vol, Box_Tare_Wght, Box_Tare_Wght_Variance, Min_Tare_Wght, Max_Tare_Wght, Adhesive, Coating, Supplier, DTS
    'FROM            dbo.Boxes

    'Select  BagID, Name, Descr, Grade, Type, Width, Length, Square_Inches, Print_Type, Tare_Wght_grams, Tare_Wght_lbs, Supplier, DTS
    'FROM            dbo.Bags



    'tied to ProductInfo
    'Select   FabPk, ProductCode, Fab_type, Fab_order, Fab_procedure, depricate, DTS
    'FROM            dbo.Fabrication

    'Select  DfctPk, ProductCode, Dfct_type, Dfct_procedure, depricate, DTS
    'FROM            dbo.Defects

    'Select  Image_pk, ProductCode, image_type, productImage, DTS
    'FROM            dbo.ProductImages





    'SELECT        pkg_pk, bagtype, bagMaterial, Bagdimension, BagBrand, BagGrade, BagWght, BagSupplier, DTS, Depricate
    'FROM            dbo.PackagingInfo

    'SELECT         pkg_id, Bag_Name, Bag_Descr, Bag_Grade, Bag_Type, BagWidth, Bag_Length, bag_sqr_inches, Print_Type, Tare_grams, Tare_lbs, Supplier, DTS
    'FROM            dbo.Packaging




End Class
