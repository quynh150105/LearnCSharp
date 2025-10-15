<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="DS">
		<html>
			<head>
				<style>
					table{
					width: 100%;
					background-color: violet;
					}
					tr,th,td{
					border:1px solid black;
					}
					.so{
					color: red;
					font-size:24px;
					}
				</style>
			</head>
			<body>
				<h1 align="center">Bang luong thang</h1>
				<xsl:apply-templates select="congty"></xsl:apply-templates>
			</body>
		</html>
    </xsl:template>

	<xsl:template match="congty">
		<h2>Ten cong ty: <xsl:value-of select="@TenCT"/> </h2>
		<xsl:apply-templates select="donvi"></xsl:apply-templates>
	</xsl:template>
	
	<xsl:template match="donvi">
		<h2>Ten phong:  <xsl:value-of select="tendv"/> </h2>
		<table cellspacing="0">
			<tr>
				<th>STT</th>
				<th>Ho Ten</th>
				<th>Ngay Sinh</th>
				<th>Ngay cong</th>
				<th>luong</th>
			</tr>
			<xsl:apply-templates select="nhanvien"></xsl:apply-templates>
		</table>
	</xsl:template>

	<xsl:template match="nhanvien">
			<tr>
				<td class="so">
					<xsl:value-of select="position()"/>
				</td>
				<td>
					<xsl:value-of select="hoten"/>
				</td>
				<td class="so">
					<xsl:value-of select="ngaysinh"/>
				</td>
				<td class="so">
					<xsl:value-of select="ngaycong"/>
				</td>
				<td class="so">
					<xsl:choose>
						<xsl:when test="ngaycong&lt;20">
							<xsl:value-of select="ngaycong*150000"/>
						</xsl:when>
						<xsl:when test="ngaycong >= 20 and ngaycong &lt;25">
							<xsl:value-of select="20*150000 + (ngaycong - 20)*200000"/>
						</xsl:when>
						<xsl:otherwise>
							<xsl:value-of select="20*150000 + 5*200000 +(ngaycong - 25)*250000"/>
						</xsl:otherwise>
					</xsl:choose>
				</td>
			</tr>
	</xsl:template>
	
	
</xsl:stylesheet>
