import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ToastService {
  toasts: any[] = [];

  showSuccess(message: string) {
    this.toasts.push({ message: message, class: 'bg-success text-light', autoHide: true });
  }

  showWarning(message: string) {
    this.toasts.push({ message: message, class: 'bg-warning text-light', autoHide: true });
  }

  showError(message: string, header: string) {
    this.toasts.push({ message: message, class: 'bg-danger text-light', autoHide: false, header: header });
  }

  remove(toast: any) {
    this.toasts = this.toasts.filter((t) => t !== toast);
  }
}
