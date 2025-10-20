<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="ns"
	xmlns:ns="http://tempuri.org/Bai5PhieuBaiTap3.xsd"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="ns:LopHoc">
		<html>
			<body>
				<h1 align="center">Danh sach mon hoc</h1>
				<table border="1" width="100%" cellspacing="0">
					<tr>
						<th align="left">MaMh</th>
						<th align="left">TenMh</th>
						<th align="left">SoGio</th>
					</tr>

					<xsl:for-each select="ns:MonHoc[ns:SoGio>40]">
						<xsl:sort select="ns:MaMh" order="descending"/>
						<tr>
							<td>
								<xsl:value-of select="ns:MaMh"/>
							</td>
							<td>
								<xsl:value-of select="ns:TenMh"/>
							</td>
							<td>
								<xsl:value-of select="ns:SoGio"/>
							</td>						
						</tr>
												
					</xsl:for-each>
				</table>

			</body>
		</html>
	   
	   
	   
	   
    </xsl:template>
</xsl:stylesheet>
