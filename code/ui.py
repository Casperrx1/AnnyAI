# code/ui.py

import tkinter as tk
from tkinter import ttk
from main import recognize_speech, generate_animation, talk_back

class SpeechAnimationUI:
    def __init__(self, root):
        self.root = root
        self.root.title("Speech-to-Animation UI")

        # Your UI components and layout here...
        self.result_text = tk.StringVar()
        self.result_entry = ttk.Entry(self.root, textvariable=self.result_text, width=40)
        self.result_entry.grid(row=0, column=0, padx=10, pady=10)

        talk_button = ttk.Button(self.root, text="Talk Back", command=self.talk_back)
        talk_button.grid(row=1, column=0, padx=10, pady=10)

    def generate_animation(self):
        user_input = self.result_text.get()
        animation_labels = generate_animation(user_input)
        # Implement animation display logic

    def run_animation(self, recognized_text):
        # Implement animation running logic
        pass

    def talk_back(self):
        text_to_speak = self.result_text.get()
        talk_back(text_to_speak)

if __name__ == "__main__":
    root = tk.Tk()
    app = SpeechAnimationUI(root)
    root.mainloop()
