"use strict";
/*
    接口  本质上是一种约束
    约束对象
*/
function getUserInfo(user) {
    console.log(`${user.name}, ${user.age}, ${user.home}`);
}
function getVipInfo(user) {
    console.log(`${user.name}, ${user.age}`);
}
getUserInfo({ name: 'chd', age: 11 });
getVipInfo({ name: 'lv', age: 10, home: 'bj' });
let cost = function (price) {
    return price * 0.8;
};
console.log(cost(100));
let arr = ['chd', 'lv', 'xiaobai'];
console.log(arr);
class Dog2 {
    constructor(name) {
        this.name = name;
        this.name = name;
    }
    speak(something) {
        console.log('小狗 汪汪汪');
    }
    fly() {
        console.log('会飞的小狗');
    }
    blueFly() {
        console.log('蜂鸟');
    }
}
let dog2 = new Dog2('柯基');
console.log(dog2);
