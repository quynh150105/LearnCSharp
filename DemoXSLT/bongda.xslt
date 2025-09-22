<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<head>
				<title>Cac than tuong bong da</title>
			</head>
			<body>
				<h2>Cac nhan vat bong da tieu bieu</h2>
				<table border="2" cellpadding="3">
					<tr>
						<td>Cau thu</td>
						<td>So ban thang</td>
						<td>So lan sut</td>
						<td>So lan duoc tao co hoi</td>
					</tr>
					<xsl:for-each select="bongda/cauthu">
						<tr>
							<td>
								<xsl:value-of select="hoten"/>
							</td>
							<td>
								<xsl:value-of select="ghiban"/>
							</td>
							<td>
								<xsl:value-of select="sosut"/>
							</td>
							<td>
								<xsl:value-of select="cohoi"/>
							</td>
						</tr>
					</xsl:for-each>					
				</table>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
