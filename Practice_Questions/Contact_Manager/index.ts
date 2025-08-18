import { ContactManager } from './ContactManager';
import { Contact } from './Contact';

const manager = new ContactManager();

const contact1: Contact = {
  id: 1,
  name: 'Alice',
  email: 'alice@example.com',
  phone: '123-456-7890',
};

const contact2: Contact = {
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
