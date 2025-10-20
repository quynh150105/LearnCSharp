<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt"
	xmlns:ns="http://tempuri.org/Bai5PhieuBaiTap1.xsd"
	exclude-result-prefixes="ns">

	<xsl:output method="html" indent="yes"/>

	<xsl:template match="ns:Lop">

		<html>
			<head></head>
			<body>
				<h1 align="center">Danh sach Lop</h1>
				<table border="1" width="100%" cellspacing="0">
					<tr>
						<th>STT</th>
						<th>MaSv</th>
						<th>TenSv</th>
						<th>GioiTinh</th>
						<th>NgaySinh</th>
						<th>MaLop</th>
					</tr>

					<xsl:apply-templates select="ns:SinhVien">
						<xsl:sort select="ns:TenSv" order="descending"/>
					</xsl:apply-templates>
				</table>

			</body>
		</html>


	</xsl:template>

	<xsl:template match="ns:SinhVien">
		<tr>
			<td>
				<xsl:value-of select="position()"/>
			</td>
			<td>
				<xsl:value-of select="@MaSv"/>
			</td>
			<td>
				<xsl:value-of select="ns:TenSv"/>
			</td>
			<td>
				<xsl:value-of select="ns:GioiTinh"/>
			</td>
			<td>
				<xsl:value-of select="ns:ngaysinh"/>
			</td>
			<td>
				<xsl:value-of select="ns:MaLop"/>
			</td>

		</tr>
	</xsl:template>


</xsl:stylesheet>
