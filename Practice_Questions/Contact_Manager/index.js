"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var ContactManager_1 = require("./ContactManager");
var manager = new ContactManager_1.ContactManager();
var contact1 = {
    id: 1,
    name: 'Alice',
    email: 'alice@example.com',
    phone: '123-456-7890',
};
var contact2 = {
    id: 2,
    name: 'Bob',
    email: 'bob@example.com',
    phone: '987-654-3210',
};
manager.addContact(contact1);
manager.addContact(contact2);
console.log('All Contacts:', manager.viewContacts());
manager.modifyContact(1, { email: 'alice_new@example.com' });
console.log('After Modification:', manager.viewContacts());
manager.deleteContact(2);
manager.deleteContact(99);
console.log('Final Contacts:', manager.viewContacts());
