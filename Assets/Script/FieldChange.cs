using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class FieldChange : MonoBehaviour {

	public class FieldPoint {
		public int FromX { get; set; }
		public int ToX { get; set; }
		public float FromHeight { get; set; }
		public float ToHeight { get; set; }
	}

	public class FieldArea {
		public FieldPoint[] Points { get; set; }

		public static FieldArea[] Get(){
			return new FieldArea[]{
				//1
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 200, ToX = 219, FromHeight = 0.0346f, ToHeight = 0.0346f },
						new FieldPoint() { FromX = 220, ToX = 239, FromHeight = 0.0346f, ToHeight = 0.0346f },
					},
				},
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 180, ToX = 199, FromHeight = 0.0346f, ToHeight = 0.0346f },
						new FieldPoint() { FromX = 240, ToX = 259, FromHeight = 0.0346f, ToHeight = 0.0346f },
					},
				},
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 160, ToX = 179, FromHeight = 0.0346f, ToHeight = 0.0346f },
						new FieldPoint() { FromX = 260, ToX = 279, FromHeight = 0.0346f, ToHeight = 0.0346f },
					},
				},
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 140, ToX = 159, FromHeight = 0.0346f, ToHeight = 0.0346f },
						new FieldPoint() { FromX = 280, ToX = 299, FromHeight = 0.0346f, ToHeight = 0.0346f },
					},
				},
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 120, ToX = 129, FromHeight = 0.0336f, ToHeight = 0.0346f },
						new FieldPoint() { FromX = 130, ToX = 139, FromHeight = 0.0346f, ToHeight = 0.0346f },
						new FieldPoint() { FromX = 300, ToX = 309, FromHeight = 0.0346f, ToHeight = 0.0346f },
						new FieldPoint() { FromX = 310, ToX = 319, FromHeight = 0.0346f, ToHeight = 0.0336f },
					},
				},
				//2
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 200, ToX = 219, FromHeight = 0.0356f, ToHeight = 0.0356f },
						new FieldPoint() { FromX = 220, ToX = 239, FromHeight = 0.0356f, ToHeight = 0.0356f },
					},
				},
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 180, ToX = 199, FromHeight = 0.0356f, ToHeight = 0.0356f },
						new FieldPoint() { FromX = 240, ToX = 259, FromHeight = 0.0356f, ToHeight = 0.0356f },
					},
				},
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 160, ToX = 179, FromHeight = 0.0356f, ToHeight = 0.0356f },
						new FieldPoint() { FromX = 260, ToX = 279, FromHeight = 0.0356f, ToHeight = 0.0356f },
					},
				},
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 140, ToX = 159, FromHeight = 0.0356f, ToHeight = 0.0356f },
						new FieldPoint() { FromX = 280, ToX = 299, FromHeight = 0.0356f, ToHeight = 0.0356f },
					},
				},
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 130, ToX = 139, FromHeight = 0.0346f, ToHeight = 0.0356f },
						new FieldPoint() { FromX = 300, ToX = 309, FromHeight = 0.0356f, ToHeight = 0.0346f },
					},
				},
				//3
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 200, ToX = 219, FromHeight = 0.0366f, ToHeight = 0.0366f },
						new FieldPoint() { FromX = 220, ToX = 239, FromHeight = 0.0366f, ToHeight = 0.0366f },
					},
				},
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 180, ToX = 199, FromHeight = 0.0366f, ToHeight = 0.0366f },
						new FieldPoint() { FromX = 240, ToX = 259, FromHeight = 0.0366f, ToHeight = 0.0366f },
					},
				},
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 160, ToX = 179, FromHeight = 0.0366f, ToHeight = 0.0366f },
						new FieldPoint() { FromX = 260, ToX = 279, FromHeight = 0.0366f, ToHeight = 0.0366f },
					},
				},
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 140, ToX = 149, FromHeight = 0.0356f, ToHeight = 0.0366f },
						new FieldPoint() { FromX = 150, ToX = 159, FromHeight = 0.0366f, ToHeight = 0.0366f },
						new FieldPoint() { FromX = 280, ToX = 289, FromHeight = 0.0366f, ToHeight = 0.0366f },
						new FieldPoint() { FromX = 290, ToX = 299, FromHeight = 0.0366f, ToHeight = 0.0356f },
					},
				},
				//4
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 200, ToX = 219, FromHeight = 0.0376f, ToHeight = 0.0376f },
						new FieldPoint() { FromX = 220, ToX = 239, FromHeight = 0.0376f, ToHeight = 0.0376f },
					},
				},
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 180, ToX = 189, FromHeight = 0.0366f, ToHeight = 0.0376f },
						new FieldPoint() { FromX = 190, ToX = 199, FromHeight = 0.0376f, ToHeight = 0.0376f },
						new FieldPoint() { FromX = 240, ToX = 249, FromHeight = 0.0376f, ToHeight = 0.0376f },
						new FieldPoint() { FromX = 250, ToX = 259, FromHeight = 0.0376f, ToHeight = 0.0366f },
					},
				},
				//5
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 200, ToX = 219, FromHeight = 0.0386f, ToHeight = 0.0386f },
						new FieldPoint() { FromX = 220, ToX = 239, FromHeight = 0.0386f, ToHeight = 0.0386f },
					},
				},
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 190, ToX = 199, FromHeight = 0.0376f, ToHeight = 0.0386f },
						new FieldPoint() { FromX = 240, ToX = 249, FromHeight = 0.0386f, ToHeight = 0.0376f },
					},
				},
				//6
				new FieldArea() {
					Points = new FieldPoint[] {
						new FieldPoint() { FromX = 200, ToX = 209, FromHeight = 0.0386f, ToHeight = 0.0396f },
						new FieldPoint() { FromX = 210, ToX = 219, FromHeight = 0.0396f, ToHeight = 0.0396f },
						new FieldPoint() { FromX = 220, ToX = 229, FromHeight = 0.0396f, ToHeight = 0.0396f },
						new FieldPoint() { FromX = 230, ToX = 239, FromHeight = 0.0396f, ToHeight = 0.0386f },
					},
				},
			};
		}
	}

	public Terrain terr; // terrain to modify
	private int hmWidth; // heightmap width
	private int hmHeight; // heightmap height
	public int Index;
	private FieldArea[] m_fields;
	private int y;
	public int Speed = 10;
	public bool IsRunning = false;

	void Start () {
		hmWidth = terr.terrainData.heightmapWidth;
		hmHeight = terr.terrainData.heightmapHeight;
		Index = 0;
		y = 0;
		m_fields = FieldArea.Get();
	}
	
	void Update () {
		if (!IsRunning)
			return;

		if (y < hmHeight)
			y += Speed;
		else if (Index < m_fields.Length - 1)
		{
			y = 0;
			Index++;
		}
		else
			return;

		float[,] heights = terr.terrainData.GetHeights(0, 0, hmWidth, hmHeight);

		foreach(var point in m_fields[Index].Points){
			for (int i = 0; i <= (point.ToX - point.FromX); i++) {
				var x = point.FromX + i;
				for (int j = y; j < y + Speed; j++) {
					if (x < hmWidth && j < hmHeight)
						heights[x, j] = point.FromHeight + ((point.ToHeight - point.FromHeight) / (point.ToX - point.FromX) * i) + Random.value * 0.0003f;
				}
			}
		}

		// set the new height
		terr.terrainData.SetHeights(0,0,heights);
	}
}