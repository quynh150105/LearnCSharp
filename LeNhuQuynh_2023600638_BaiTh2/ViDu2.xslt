<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>
	    
	
    <xsl:template match="/">
		<html>
			<body>
				<xsl:variable name="so1" select="/GOC/SO[1]"></xsl:variable>
				<xsl:variable name="so2" select="/GOC/SO[2]"></xsl:variable>
				<h1>So lon nhat giua 2 so </h1>

				<xsl:value-of select="$so1"></xsl:value-of>
				va

				<xsl:value-of select="$so2"></xsl:value-of>

				la:

				<xsl:if test="$so1 > $so2">
					<xsl:value-of select="$so1"></xsl:value-of>
				</xsl:if>
				<xsl:if test="$so1 &lt;= $so2">
					<xsl:value-of select="$so2"></xsl:value-of>
				</xsl:if>




			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
