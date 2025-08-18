"use strict";
var __assign = (this && this.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.ContactManager = void 0;
var ContactManager = /** @class */ (function () {
    function ContactManager() {
        this.contacts = [];
    }
    ContactManager.prototype.addContact = function (contact) {
        this.contacts.push(contact);
        console.log("Contact with id ".concat(contact.id, " added successfully."));
    };
    ContactManager.prototype.viewContacts = function () {
        return this.contacts;
    };
    ContactManager.prototype.modifyContact = function (id, updatedContact) {
        var index = this.contacts.findIndex(function (contact) { return contact.id === id; });
        if (index === -1) {
            console.error("Contact with id ".concat(id, " not found."));
            return;
        }
        this.contacts[index] = __assign(__assign({}, this.contacts[index]), updatedContact);
        console.log("Contact with id ".concat(id, " modified successfully."));
    };
    ContactManager.prototype.deleteContact = function (id) {
        var index = this.contacts.findIndex(function (contact) { return contact.id === id; });
        if (index === -1) {
            console.error("Contact with id ".concat(id, " not found."));
            return;
        }
        this.contacts.splice(index, 1);
        console.log("Contact with id ".concat(id, " deleted successfully."));
    };
    return ContactManager;
}());
exports.ContactManager = ContactManager;
