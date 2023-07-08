interface Observer {
  update(available: boolean): void;
}

interface Subject {
  attach(observer: Observer): void;
  detach(observer: Observer): void;
  notify(available: boolean): void;
}

class Store implements Subject {
  private observers: Observer[] = [];
  private available: boolean = false;

  attach(observer: Observer): void {
    this.observers.push(observer);
  }

  detach(observer: Observer): void {
    const index = this.observers.indexOf(observer);
    if (index !== -1) {
      this.observers.splice(index, 1);
    }
  }

  notify(available: boolean): void {
    this.available = available;
    this.observers.forEach((observer) => observer.update(available));
  }

  checkAvailability(): void {
    const available = Math.random() < 0.5;
    this.notify(available);
  }
}

class Person implements Observer {
  private name: string;

  constructor(name: string) {
    this.name = name;
  }

  update(available: boolean): void {
    if (available) {
      console.log(`[${this.name}] - iPhone 12 is available!`);
    } else {
      console.log(`[${this.name}] - iPhone 12 is not available yet.`);
    }
  }
}

const store = new Store();

const person1 = new Person("AAAAAA");
const person2 = new Person("BBBBBB");
const person3 = new Person("CCCCCC");

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
