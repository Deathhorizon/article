"use strict";
// 参数的泛型，用的不多
function calc(val) {
    return val;
}
console.log(calc(1));
console.log(calc('wow'));
// 类的泛型
class MyArr {
    constructor() {
        this.list = []; // 定义一个私有的属性list
    }
    add(val) {
        this.list.push(val);
    }
    max() {
        let ret = this.list[0];
        for (let i = 1; i < this.list.length; i++) {
            if (this.list[i] > ret) {
                ret = this.list[i];
            }
        }
        return ret;
    }
}
let myArr = new MyArr();
myArr.add(3);
myArr.add(1);
myArr.add(10);
console.log(myArr.max());
