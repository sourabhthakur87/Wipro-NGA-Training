import { Contact } from './Contact';

export class ContactManager {
  private contacts: Contact[] = [];

  addContact(contact: Contact): void {
    this.contacts.push(contact);
    console.log(`Contact with id ${contact.id} added successfully.`);
  }

  viewContacts(): Contact[] {
    return this.contacts;
  }

  modifyContact(id: number, updatedContact: Partial<Contact>): void {
    const index = this.contacts.findIndex(contact => contact.id === id);
    if (index === -1) {
      console.error(`Contact with id ${id} not found.`);
      return;
    }

    this.contacts[index] = { ...this.contacts[index], ...updatedContact };
    console.log(`Contact with id ${id} modified successfully.`);
  }

  deleteContact(id: number): void {
    const index = this.contacts.findIndex(contact => contact.id === id);
    if (index === -1) {
      console.error(`Contact with id ${id} not found.`);
      return;
    }

    this.contacts.splice(index, 1);
    console.log(`Contact with id ${id} deleted successfully.`);
  }
}
