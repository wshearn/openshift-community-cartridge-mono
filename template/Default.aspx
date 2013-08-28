<%@ Page Language="C#"%>
<html>
<head>
<title>Hello World from ASPX on OpenShift!</title>
</head>
<body>
  <% for (int i=1; i<=6; i++) {
   Response.Write("<h" + i + ">Hello World!</h" + i + ">");
   } %>
</body>
</html>
