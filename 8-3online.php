<!DOCTYPE HTML>
<html lang="en-US">
<head>
	<meta charset="UTF-8">
	<title>Ngày 8-3 (Quốc tế phụ nữ)</title>
	<style type="text/css">
		*{
			margin:0;
			padding:0;
		}
		body{
			height:800px;
			background:url(img/background.jpg)
		}
	</style>
	<script type="text/javascript">
		function calcHeight(){
			var dodai_trang = document.getElementById('ifContent').contentWindow.document.body.scrollHeight;
			document.getElementById('ifContent').height=dodai_trang;
		}
		function changeContent(sourcePath){
			if(document.getElementById){
				target=document.getElementById('ifContent');
				target.src=sourcePath;
				
				
				
			}
		}
	</script>
</head>
<body>
	<table style="margin-left:11%" width="1024" border="0" cellspacing="0" bgcolor="#AFFEB1">
		<tr>
			<td colspan="2" align="center">
				<img src="img/banner.jpg" height="140" width="1024" alt="anhnen" />
			</td>
		</tr>
		<tr height="40">
			<td colspan="2" align="center">
				<font color="#003366"><b>Trang chủ | Giới thiệu | Sản phẩm | Khuyến mãi | Liên hệ</b></font>
			</td>
		</tr>
		<tr>
			<td width="80" align="left" valign="top">
				&nbsp&nbsp-<a href="#" onclick="changeContent('bonghoa.html')"> Hoa tình yêu</a><br>
				&nbsp&nbsp-<a href="#" onclick="changeContent('hoabo.html')"> Hoa bó</a><br>
				&nbsp&nbsp- <a href="#" onclick="changeContent('https://mrhoa.com/danh-muc/hoa-tinh-yeu/')">Hoa giỏ</a><br>
				&nbsp&nbsp- <a href="#" onclick="changeContent('https://hoatuoi360.vn/hoa-cam-tay-co-dau/')">Hoa cưới</a><br>
				&nbsp&nbsp- <a href="#" onclick="changeContent('https://thegioihoahong.com/product-tag/hop-hoa-tuoi/')">Hoa hộp</a><br>	
				&nbsp&nbsp- <a href="#" onclick="changeContent('https://lala.com.vn/hop-hoa-sap')">Một số mẫu khác...</a><br>					
			</td>
			<td width="86%" align="left" valign="top"><iframe id="ifContent" src="bonghoa.html" 
				width="100%" onload="calcHeight();" name="content" frameborder="0" scrolling="no" height="550px"></iframe></td>
			
		</tr>
		<tr>
			<td colspan="2" align="center" style="color:#8A2BE2; font-size:22px; padding:9px;0px">Design by GiangNam - September 3, 2022</td>
		</tr>
	</table>
	
</body>
</html>