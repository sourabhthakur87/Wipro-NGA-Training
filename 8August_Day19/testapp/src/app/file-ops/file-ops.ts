import { Component } from '@angular/core';
import { FileService } from '../file.service';

@Component({
  selector: 'app-file-ops',
  standalone: false,
  templateUrl: './file-ops.html',
  styleUrl: './file-ops.css'
})

export class FileOps {
  content = '';
  newName = '';
  message = '';

  constructor(private fileService: FileService) { }

  handleWrite() {
    this.fileService.write(this.content).subscribe({
      next: (res) => this.message = res.message,
      error: (err) => this.message = err.error?.error || 'Error writing file'
    });
  }

  handleRead() {
    this.fileService.read().subscribe({
      next: (res) => {
        this.content = res.content;
        this.message = 'File read successfully';
      },
      error: (err) => this.message = err.error?.error || 'Error reading file'
    });
  }

  handleDelete() {
    this.fileService.delete().subscribe({
      next: (res) => this.message = res.message,
      error: (err) => this.message = err.error?.error || 'Error deleting file'
    });
  }

  handleRename() {
    this.fileService.rename(this.newName).subscribe({
      next: (res) => this.message = res.message,
      error: (err) => this.message = err.error?.error || 'Error renaming file'
    });
  }
}
