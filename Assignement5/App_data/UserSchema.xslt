<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/">
    <html>
      <body>
        <h1>Registered Users</h1>
        <table border="1">
          <tr bgcolor="lightgrey">
            <td>
              <b>UserName</b>
            </td>
            <td>
              <b>Password</b>
            </td>
            <td>
              <b>Address</b>
            </td>
            <td>
              <b>Email</b>
            </td>
            <td>
              <b>Email</b>
            </td>
            <td>
              <b>Phone</b>
            </td>
            <td>
              <b>Role</b>
            </td>
          </tr>
          <xsl:for-each select="Users/User">
            <xsl:sort select="UserName" />
            <tr style="font-size: 10pt; font-family: verdana">
              <td>
                <xsl:value-of select="UserName"/>
              </td>
              <td>
                <xsl:value-of select="Password"/>
              </td>
              <td>
                <xsl:value-of select="FirstName"/>
              </td>
              <td>
                <xsl:value-of select="Address"/>
                <br/>
                <xsl:value-of select="City"/>
              </td>
              <td>
                <xsl:value-of select="Email"/>
              </td>
              <td>
                <xsl:value-of select="PhoneNumber"/>
              </td>
              <td>
                <xsl:value-of select="Role"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
