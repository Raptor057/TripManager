CREATE TABLE [dbo].[SavedGlobalSettings] (
  [Id] INT NOT NULL PRIMARY KEY,
  [Name] NVARCHAR(128) NOT NULL,           -- Ej: 'Central Standard Time'
  [CurrentUtcOffset] TIME NULL,            -- Opcional, solo para referencia
  [IsCurrentlyDst] BIT NULL,               -- Opcional, solo para referencia
  [Description] NVARCHAR(256) NULL,        -- Opcional, para comentarios o descripciones
  [CreatedAt] DATETIME NOT NULL DEFAULT GETUTCDATE(),
  [UpdatedAt] DATETIME NULL DEFAULT GETUTCDATE()
);
