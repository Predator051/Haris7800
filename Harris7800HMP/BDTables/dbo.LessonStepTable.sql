CREATE TABLE [dbo].[LessonStep]
(
	[Lesson_id] INT NOT NULL, 
    [Step_id] INT NOT NULL, 
    [Next_step_id] INT NULL, 
    CONSTRAINT [PK_LessonStep] PRIMARY KEY ([Lesson_id], [Step_id]), 
    CONSTRAINT [FK_LessonStep_ToLesson] FOREIGN KEY ([Lesson_id]) REFERENCES [Lessons]([Id]),
    CONSTRAINT [FK_LessonStep_ToStep] FOREIGN KEY ([Step_id]) REFERENCES [Steps]([Id]),
    CONSTRAINT [FK_LessonStepNext_ToStep] FOREIGN KEY ([Next_step_id]) REFERENCES [Steps]([Id])
)
