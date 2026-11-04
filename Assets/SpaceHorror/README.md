# Space Horror tilemap setup

This project uses Unity's built-in **Grid**, **Tilemap**, and **Tile Palette**.
The empty map scene is `Assets/Scenes/SpaceHorror_Map.unity`.
The populated reference scene is `Assets/SpaceHorror/Scenes/SpaceHorror_Starter.unity`.

## Paint a map

1. Open **Window > 2D > Tile Palette**.
2. Select **Space Horror - Solid** and set **Active Tilemap** to **Ground** for
   floors, walls and platforms. Use **Space Horror - Visual** with **Background**,
   **Decoration** or **Foreground** for artwork that should not block movement.
3. Click a tile or drag across several adjacent tiles in the palette to select a
   stamp. The palette preserves the original tilesheet layout, including gaps.
4. Paint in the **Scene** view. Use Unity's Tile Palette toolbar for brush, erase,
   box and fill. Standard shortcuts: **B** brush, **D** erase, **G** fill.
5. **Ctrl+Z** undoes painting. **Ctrl+S** saves the map scene.

Keep the Tile Palette locked while editing a map. Its edit/unlock control changes
the palette asset itself. To make another map, use **File > Save As** on the empty
map scene. Choose the intended layer using **Active Tilemap** in Tile Palette.

## Assets and layers

- Original pack: `Assets/Art/2D Pixel Space Horror Pack`, including all sounds,
  character sheets, effects and reference images. Original image/audio bytes are unchanged.
- Tiles: **16 × 16 pixels**, **16 pixels per unit**, point filtering, no mipmaps,
  uncompressed, full-rectangle sprite meshes. Fully transparent cells are omitted.
- Survivor/undead: **32 × 32 frames**, also 16 pixels per unit. These are sliced
  frames; animations and gameplay are not part of the map editor.
- **Space Horror - Visual** palette: no tile collision.
- **Space Horror - Solid** palette: full-cell grid collision. Use it on Ground.
- Layer draw order: Background **-20**, Ground **0**, Decoration **10**, Foreground **20**.
- Ground: static Rigidbody2D, TilemapCollider2D and CompositeCollider2D. The other
  tilemaps have no colliders. Keep decorative tiles on a visual layer.
- The starter includes a survivor sprite only as a scale reference.
- The sprite material is unlit, so the original art is visible without lights.
  The 40 × 22.5-unit camera corresponds to 640 × 360 source pixels; use a 16:9 Game
  view at an integer multiple of that resolution for a crisp preview.

Maps contain standard Unity Grid, Tilemap, Tile and collider components. No custom
map editor window, map runtime, or extra packages are required. In the populated
reference scene, the solid layer is named **Terrain** instead of **Ground**.

