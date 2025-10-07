<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html" encoding="utf-8" indent="yes"/>

	<xsl:template match="/">
		<html>
			<head>
				<title>Tính tiền điện bằng &lt;xsl:choose&gt;</title>
				<style>
					body { font-family: Arial; }
					table { border-collapse: collapse; margin-top: 10px; }
					th, td { border: 1px solid #555; padding: 6px 12px; text-align: center; }
					th { background: #f2f2f2; }
				</style>
			</head>
			<body>
				<h2>HÓA ĐƠN TIỀN ĐIỆN</h2>

				<xsl:variable name="dau" select="/chiSo/dau"/>
				<xsl:variable name="cuoi" select="/chiSo/cuoi"/>
				<xsl:variable name="soDien" select="$cuoi - $dau"/>

				<p>
					Chỉ số đầu: <xsl:value-of select="$dau"/> kWh
				</p>
				<p>
					Chỉ số cuối: <xsl:value-of select="$cuoi"/> kWh
				</p>
				<p>
					Sản lượng điện tiêu thụ: <b>
						<xsl:value-of select="$soDien"/>
					</b> kWh
				</p>

				<xsl:variable name="donGia">
					<xsl:choose>
						<xsl:when test="$soDien &lt;= 100">
							<xsl:value-of select="$soDien * 3000"/>
						</xsl:when>
						<xsl:when test="$soDien &lt;= 150">
							<xsl:value-of select="100*3000 + ($soDien - 100)*4000"/>
						</xsl:when>
						<xsl:when test="$soDien &lt;= 200">
							<xsl:value-of select="100*3000 + 50*4000 + ($soDien - 150)*4500"/>
						</xsl:when>
						<xsl:otherwise>
							<xsl:value-of select="100*3000 + 50*4000 + 50*4500 + ($soDien - 200)*5000"/>
						</xsl:otherwise>
					</xsl:choose>
				</xsl:variable>

				
				<xsl:variable name="tien" select="$donGia"/>

				<table>
					<tr>
						<th>Chỉ số đầu</th>
						<th>Chỉ số cuối</th>
						<th>Sản lượng</th>
						<th>Thành tiền (đ)</th>
					</tr>
					<tr>
						<td>
							<xsl:value-of select="$dau"/>
						</td>
						<td>
							<xsl:value-of select="$cuoi"/>
						</td>
						<td>
							<xsl:value-of select="$soDien"/>
						</td>
						<td>
							<xsl:value-of select="$tien"/>
						</td>
					</tr>
				</table>

				<h3>
					Tổng tiền phải trả: <span style="color:red;">
						<xsl:value-of select="$tien"/> đồng
					</span>
				</h3>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>