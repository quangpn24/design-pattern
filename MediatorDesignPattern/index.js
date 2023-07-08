// Implement 1
// Mediator
class ChatRoom {
  constructor() {
    this.members = {};
  }

  addMember(member) {
    this.members[member.name] = member;
    member.chatroom = this;
  }

  send(message, fromMember, toMember) {
    toMember.receive(message, fromMember);
  }
}

// Colleague
class Member {
  constructor(name) {
    this.name = name;
    this.chatroom = null;
  }

  send(message, toMember) {
    this.chatroom.send(message, this, toMember);
  }

  receive(message, fromMember) {
    console.log(`${fromMember.name} to ${this.name}: ${message}`);
  }
}

// Usage
const chat = new ChatRoom();

const bob = new Member("Bob");
const john = new Member("John");
const tim = new Member("Tim");

chat.addMember(bob);
chat.addMember(john);
chat.addMember(tim);

bob.send("Hey, John", john); // Bob to John: Hey, John
john.send("What's up, Bob", bob); // John to Bob: What's up, Bob
tim.send("John, are you ok?", john); // Tim to John: John, are you ok?
