"use strict";
/*
    数据类型：
        boolean 布尔
        number  数字
        string  字符串

        string[]  字符串数组(数组里的类型只能是string)

        元组类型(tuple)
        枚举类型(enum)
*/
let isMarried = true;
isMarried = false;
let age = 20;
let firstname = 'chd';
let hobby = ['抽烟', '喝酒', '烫头'];
let numbers = [4, 5, 6];
let str = ['1', 'a', 'c'];
let students = [{ name: 'chd' }, { name: 'lv' }];
let fullname = ['张', '三', 100];
let arr2 = [1, 'www'];
// 定义了一个枚举类型的值
var Gender;
(function (Gender) {
    Gender["GIRL"] = "\u5973\u751F";
    Gender["BOY"] = "\u7537\u751F";
})(Gender || (Gender = {}));
console.log(`李雷是${Gender.BOY}, 韩梅梅是${Gender.GIRL}`);
// 栗子： 去拼多多买货
var OrderStatus;
(function (OrderStatus) {
    OrderStatus["WaitForPay"] = "\u7B49\u5F85\u4ED8\u6B3E";
    OrderStatus["WaitForSend"] = "\u7B49\u5F85\u53D1\u8D27";
    OrderStatus["Sended"] = "\u5DF2\u53D1\u8D27";
    OrderStatus["Signed"] = "\u5DF2\u7B7E\u6536";
})(OrderStatus || (OrderStatus = {}));
let array = ['1', '2', 'bobo'];
for (let i in array) {
    console.log(i);
}
for (let j of array) {
    console.log(j);
}
