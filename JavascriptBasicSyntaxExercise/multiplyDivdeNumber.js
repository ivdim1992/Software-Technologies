function multiPlyOrDivideNumber(numbers) {
let number1 = Number(numbers[0]);
let number2 = Number(numbers[1]);

if (number2 >= number1){
    let result = number1 * number2;
    console.log(result);
}
else if (number1 > number2) {
    let result = number1 / number2;
    console.log(result);
}
}

multiPlyOrDivideNumber(['3','2']);