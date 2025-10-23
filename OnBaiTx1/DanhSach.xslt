<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="ns"
	xmlns:ns="http://tempuri.org/DanhSach.xsd"
				>
    <xsl:output method="html" indent="yes"/>
    <xsl:template match="ns:DS">
		<html>
			<body>
				<h1 align="center">Bang Luong Thang</h1>
				<xsl:for-each select="ns:congty">
					<h2>Ten cong ty: <xsl:value-of select="@TenCT"/> </h2>
					<xsl:for-each select="ns:donvi">
						<h2>Ten phong: <xsl:value-of select="ns:tendv"/> </h2>

						<table border="1" cellspacing="0" width="100%">
							<tr>
								<th>STT</th>
								<th>Ho Ten</th>
								<th>Ngay Sinh</th>
								<th>Ngay cong</th>
								<th>Luong</th>
							</tr>

							<xsl:for-each select="ns:nhanvien">
								<tr>
									<td>
										<xsl:value-of select="position()"/>
									</td>
									<td>
										<xsl:value-of select="ns:hoten"/>
									</td>
									<td>
										<xsl:value-of select="ns:ngaysinh"/>
									</td>
									<td>
										<xsl:value-of select="ns:ngaycong"/>
									</td>
									<td>
										<xsl:choose>
											<xsl:when test="ns:ngaycong &lt; 20">
												<xsl:value-of select="ns:ngaycong*150000"/>
											</xsl:when>
											<xsl:when test="ns:ngaycong>=20 and ns:ngaycong&lt; 25">
												<xsl:value-of select="20*150000 + (ns:ngaycong - 20)*200000 "/>
											</xsl:when>
											<xsl:otherwise>
												<xsl:value-of select="20*150000 + 5*200000 +(ns:ngaycong - 25)*250000"/>
											</xsl:otherwise>
										</xsl:choose>
									</td>
								</tr>				
							</xsl:for-each>
						</table>
					</xsl:for-each>
				</xsl:for-each>
			</body>
		</html>        
    </xsl:template>
</xsl:stylesheet>
