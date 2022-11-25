USE [StokYonetimi]
GO

/****** Object:  StoredProcedure [dbo].[sp_Cariler]    Script Date: 19.01.2022 17:12:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_Cariler]
@CariKodu AS char(5)
AS
BEGIN
   SELECT * FROM dbo.Cariler WHERE Cari_Kodu=@CariKodu
END
GO

