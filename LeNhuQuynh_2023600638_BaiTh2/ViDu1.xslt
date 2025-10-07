<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<body>
				<b>Tong 2 so la: </b>
				<xsl:value-of select="/GOC/SO[1]"/>+
				<xsl:value-of select="/GOC/SO[2]"/> =
				<xsl:value-of select="/GOC/SO[1] + /GOC/SO[2]"/>
				
			</body>
		</html>
        
    </xsl:template>
</xsl:stylesheet>
