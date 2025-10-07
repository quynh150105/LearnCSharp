<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<body>
				<xsl:variable name="hsa" select="/goc/hsa"></xsl:variable>
				<xsl:variable name="hsb" select="/goc/hsb"></xsl:variable>
				<h1>Phuong trinh AX+B=0</h1>
				<p>voi a= <xsl:value-of select="$hsa"/>va b= <xsl:value-of select="$hsb"/> </p>
				<p>co nghiem la: x= <xsl:value-of select="-($hsb div $hsa)"/></p>
				
				
				
			</body>
		</html>
		
		
		
		
    </xsl:template>
</xsl:stylesheet>
