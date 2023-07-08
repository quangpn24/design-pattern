var Store = /** @class */ (function () {
    function Store() {
        this.observers = [];
        this.available = false;
    }
    Store.prototype.attach = function (observer) {
        this.observers.push(observer);
    };
    Store.prototype.detach = function (observer) {
        var index = this.observers.indexOf(observer);
        if (index !== -1) {
            this.observers.splice(index, 1);
        }
    };
    Store.prototype.notify = function (available) {
        this.available = available;
        this.observers.forEach(function (observer) { return observer.update(available); });
    };
    Store.prototype.checkAvailability = function () {
        var available = Math.random() < 0.5;
        this.notify(available);
    };
    return Store;
}());
var Person = /** @class */ (function () {
    function Person(name) {
        this.name = name;
    }
    Person.prototype.update = function (available) {
        if (available) {
            console.log("[".concat(this.name, "] - iPhone 12 is available!"));
        }
        else {
            console.log("[".concat(this.name, "] - iPhone 12 is not available yet."));
        }
    };
    return Person;
}());
var store = new Store();
var person1 = new Person("AAAAAA");
var person2 = new Person("BBBBBB");
var person3 = new Person("CCCCCC");
store.attach(person1);
store.attach(person2);
store.attach(person3);
store.checkAvailability();
// Output:
// [Person 1] - iPhone 12 is available!
// [Person 2] - iPhone 12 is available!
// [Person 3] - iPhone 12 is available!
store.detach(person3);
store.checkAvailability();
// Output:
// [Person 1] - iPhone 12 is available!
// [Person 2] - iPhone 12 is available!
