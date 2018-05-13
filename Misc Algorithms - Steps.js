steps(10);



/*****************
	Solution 1
*****************/
function steps(n) {
	var pounds = "";
	var spaces = "";
	var outputs = "";

	if (n > 0) {
		for (let x = 1; x <= n; x++) {
			spaces += " ";
		}

		for (let x = 1; x <= n; x++) {
			pounds += "#";
			outputs += "'" + pounds + spaces.toString().slice(0, n - pounds.length) + "'\n";
		}

		console.log(outputs);
	}
}



/*****************
	Solution 2
*****************/
function steps(n) {
	for (let row = 1; row <= n; row++) {

		let stair = "";

		for (let col = 1; col <= n; col++) {
			if (col <= row) {
				stair += "#";
			}
			else {
				stair += " ";
			}
		}

		console.log("'" + stair + "'");
	}
}



/*****************
	Solution 3
*****************/
function steps(n, row = 0, stair = "") {
	if (n === row) {
		return;
	}

	if (n == stair.length) {
		console.log(stair);
		return steps(n, row + 1);
	}

	if (stair.legnth <= row) {
		stair += "#";
	}
	else {
		stair += " ";
	}

	steps(n, row, stair);
}