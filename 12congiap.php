<!DOCTYPE HTML>
<html lang="en-US">
<head>
	<meta charset="UTF-8">
	<title>12-ConGiap</title>
	<script type="text/javascript">
		function changeImage(file){
			window.document.hinh.src="images/"+file;
		}
	</script>
</head>
<body>
	<form action="#" method="get" name="12congiap">
		<table align="center" border="1" cellpadding="0" cellspacing="0">
			<tr>
				<td colspan="6" ><img name="hinh" src="images/ty.jpg" width="420px" height="290px" alt="con chuot" /></td>
			</tr>
			<tr>
				<td><input type="radio" name="hinhcongiap" value="ti.jpg" checked onclick="changeImage(this.value);"/>&nbspTí</td>
				<td><input type="radio" name="hinhcongiap" value="suu.jpg" onclick="changeImage(this.value);">&nbspSửu</td>
				<td><input type="radio" name="hinhcongiap" value="dan.jpg" onclick="changeImage(this.value);">&nbspDần</td>
				<td><input type="radio" name="hinhcongiap" value="mao.jpg" onclick="changeImage(this.value);">&nbspMão</td>
				<td><input type="radio" name="hinhcongiap" value="thin.jpg" onclick="changeImage(this.value);">&nbspThìn</td>
				<td><input type="radio" name="hinhcongiap" value="ty.jpg" onclick="changeImage(this.value);">&nbspTỵ</td>
			</tr>
			<tr>
				<td><input type="radio" name="hinhcongiap" value="ngo.jpg" onclick="changeImage(this.value);">&nbspNgọ</td>
				<td><input type="radio" name="hinhcongiap" value="mui.jpg" onclick="changeImage(this.value);">&nbspMùi</td>
				<td><input type="radio" name="hinhcongiap" value="than.jpg" onclick="changeImage(this.value);">&nbspThân</td>
				<td><input type="radio" name="hinhcongiap" value="dau.jpg" onclick="changeImage(this.value);">&nbspDậu</td>
				<td><input type="radio" name="hinhcongiap" value="tuat.jpg" onclick="changeImage(this.value);">&nbspTuất</td>
				<td><input type="radio" name="hinhcongiap" value="hoi.jpg" onclick="changeImage(this.value);">&nbspHợi</td>
			</tr>
		</table>
	</form>
</body>
</html>