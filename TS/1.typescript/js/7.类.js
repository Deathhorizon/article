"use strict";
class Person {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }
    getName() {
        return this.name;
    }
}
let p1 = new Person('chd', 10);
console.log(p1);
// 继承
class Other extends Person {
    constructor(name, age, no) {
        super(name, age);
        this.no = no;
    }
    getNo() {
        return this.no;
    }
}
let o1 = new Other('chd', 11, 7);
console.log(o1);
// 修饰符
/*
    public      公开的，自己，子类，其他类都能访问
    protected   受保护的，自己，子类能访问，but其他人不能访问
    private     私有的，只有自己访问，子类，其他人都不能访问
*/
class Father {
    constructor(name, age, money) {
        this.name = name;
        this.age = age;
        this.money = money;
    }
    getName() {
        return this.name;
    }
    getMoney() {
        return this.money;
    }
}
class Child extends Father {
    getAge() {
        return this.age;
    }
}
let child = new Child('chd', 11, 2019);
console.log(child.name);
// console.log(child.age);      不能访问
// console.log(child.money);    不能访问
class Animal {
    constructor(name) {
        this.name = name;
        this.name = name;
    }
}
