<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="congty">
		<html>
			<head>
				<style>
					th{
					background-color: lightblue;
					cursor: pointer;
					transition: 0.3s;
					}
					th:hover {
					background-color: orange;
					}
					th:hover {
					background-color: #45a049;
					}
					tr:hover {
					background-color: #f2f2f2;
					}


				</style>
			</head>
			<body>
				<h1 align="center">Bang Luong Thang 10-2025</h1>
				<xsl:apply-templates select="donvi"></xsl:apply-templates>
			</body>
		</html>	
    </xsl:template>

	<xsl:template match="donvi">
		<h2>Ma don vi: <xsl:value-of select="@madv"/></h2>
		<h2>Ten don vi: <xsl:value-of select="tendv"/> </h2>
		<h2>Dien thoai: <xsl:value-of select="dienthoai"/> </h2>
		<h2 align="center"> Danh sach nhan vien</h2>
		<table border="1" width="100%" cellspacing="0">
			<tr>
				<th>So TT</th>
				<th>MaNV</th>
				<th>Ho Ten</th>
				<th>Ngay sinh</th>
				<th>He So Luong</th>
				<th>Luong</th>
			</tr>
			<xsl:apply-templates select="nhanvien"></xsl:apply-templates>
		</table>
	</xsl:template>


	<xsl:template match="nhanvien">
		<tr>
			<td>
				<xsl:value-of select="position()"/>
			</td>
			<td>
				<xsl:value-of select="manv"/>
			</td>
			<td>
				<xsl:value-of select="hoten"/>
			</td>
			<td>
				<xsl:value-of select="ngaysinh"/>
			</td>
			<td>
				<xsl:value-of select="hsluong"/>
			</td>
			<td>
				<xsl:value-of select="hsluong*10000"/>
			</td>
		</tr>
	</xsl:template>
	
	

</xsl:stylesheet>
